using Phone_App.Commands;
using Phone_App.DBModels;
using Phone_App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Phone_App.ViewModels
{
    public class NewContactViewModel : INotifyPropertyChanged
    {
        private AppDBContext _dbContext;

        public ICommand AddContact { get; set; }
        public ContactsBookModel NewContact { get; set; }

        public NewContactViewModel(AppDBContext dbContext)
        {
            NewContact = new ContactsBookModel();
            _dbContext = dbContext;
            AddContact = new RelayCommand(AddNewContact, TryAddContact);
        }

        private bool TryAddContact(object obj) => true;

        private void AddNewContact(object obj)
        {
            var lastAddedContact = _dbContext.Contacts
            .OrderByDescending(c => c.ID) // Replace with the actual timestamp or ID property
            .FirstOrDefault();

            int newContactId = (lastAddedContact != null) ? lastAddedContact.ID + 1 : 1;

            ContactsEntity newContact = new ContactsEntity
            {
                ID = newContactId, 
                Name = NewContact.Name,
                Number = NewContact.Number,
                Email = NewContact.Email,
                Address = NewContact.Address
            };

            _dbContext.Contacts.Add(newContact);
            _dbContext.SaveChanges();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
