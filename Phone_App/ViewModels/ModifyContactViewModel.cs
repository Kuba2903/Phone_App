using Phone_App.Commands;
using Phone_App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Phone_App.ViewModels
{
    public class ModifyContactViewModel
    {
        private AppDBContext _dbContext;
        public ContactsBookModel Contacts { get; set; }
        public ICommand ModifyContactCommand { get; set; }

        public ModifyContactViewModel(AppDBContext context)
        {
            Contacts = new ContactsBookModel();
            _dbContext = context;
            ModifyContactCommand = new RelayCommand(ModifyContact, TryModifyContact);
        }

        private bool TryModifyContact(object obj) => true;

        private void ModifyContact(object obj)
        {
            var contactToModify = _dbContext.Contacts.FirstOrDefault(c => c.ID == Contacts.Id);

            if(contactToModify != null)
            {
                contactToModify.Name = Contacts.Name;
                contactToModify.Number = Contacts.Number;
                contactToModify.Email = Contacts.Email;
                contactToModify.Address = Contacts.Address;
                _dbContext.Contacts.Update(contactToModify);
                _dbContext.SaveChanges();
            }
        }

    }
}
