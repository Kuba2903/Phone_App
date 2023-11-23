using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Phone_App.Commands;
using Phone_App.DBModels;
using Phone_App.Models;
using Phone_App.Views;
namespace Phone_App.ViewModels
{
    public class ContactsBookViewModel : INotifyPropertyChanged
    {
        private AppDBContext _dbContext;

        private ObservableCollection<ContactsEntity> model;

        public ObservableCollection<ContactsEntity> Model
        {
            get { return model; }
            set
            {
                if (model != value)
                {
                    model = value;
                    OnPropertyChanged(nameof(Model));
                }
            }
        }

        public ICommand AddContactCommand { get; set; }
        public ICommand DeleteContactCommand { get; set; }
        public ICommand ModifyContactCommand { get; set; }
        private int contactIdToDelete;
        public int ContactIdToDelete
        {
            get { return contactIdToDelete; }
            set
            {
                if (contactIdToDelete != value)
                {
                    contactIdToDelete = value;
                    OnPropertyChanged(nameof(ContactIdToDelete));
                }
            }
        }
        public ContactsBookViewModel()
        {
            _dbContext = new AppDBContext();
            LoadContacts();
            AddContactCommand = new RelayCommand(AddNewContact, TryAddContact);
            DeleteContactCommand = new RelayCommand(DeleteContact, TryDeleteContact);
            ModifyContactCommand = new RelayCommand(ModifyContact, TryModifyContact);
        }

        private void ModifyContact(object obj)
        {
            ModifyContactViewModel viewModel = new ModifyContactViewModel(_dbContext);
            ModifyContactView view = new ModifyContactView(_dbContext);
            view.DataContext = viewModel;
            view.ShowDialog();

            LoadContacts();
        }

        private bool TryModifyContact(object obj) => true;

        private bool TryDeleteContact(object obj) => true;

        private void DeleteContact(object obj)
        {
            var contactToDelete = _dbContext.Contacts.FirstOrDefault(c => c.ID == ContactIdToDelete);
            if (contactToDelete != null)
            {
                _dbContext.Contacts.Remove(contactToDelete);
                _dbContext.SaveChanges();
                LoadContacts(); // Refresh the DataGrid after deletion
                ContactIdToDelete = 0; 
            }
        }

        private bool TryAddContact(object obj) => true;

        private void AddNewContact(object obj)
        {
            NewContactViewModel newContactViewModel = new NewContactViewModel(_dbContext);
            NewContactView view = new NewContactView(_dbContext);
            view.DataContext = newContactViewModel;
            view.ShowDialog();

            // Refresh the DataGrid after adding a new contact
            LoadContacts();
        }

        private void LoadContacts()
        {
            // Load contacts from the database and update the Model
            Model = new ObservableCollection<ContactsEntity>(_dbContext.Contacts.ToList());
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
       

    }
}
