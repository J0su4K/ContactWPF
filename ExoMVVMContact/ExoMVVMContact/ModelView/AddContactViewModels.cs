using ExoMVVMContact.Models;
using ExoMVVMContact.Utils;
using ExoMVVMContact.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoMVVMContact.ModelView
{
    public class AddContactViewModels
    {
        public Contact Contact { get; set; }
        public RelayCommand CloseCommand => new RelayCommand(CloseContactWindow);



        public AddContactViewModels()
        {
            Contact = new Contact();
        }

        void CloseContactWindow(object _obj)
        {
            //TODO AddContact
            AddContact();
            AddContactWindow _window =(AddContactWindow)_obj;
            _window.Close();
        }
        void AddContact()
        {
            if (string.IsNullOrEmpty(Contact.Email)
                || string.IsNullOrEmpty(Contact.Name)
                || string.IsNullOrEmpty(Contact.FirstName)) return; 
            ContactManager.Contacts.Add(Contact);
            ContactManager.OnContactAdded(Contact);
        }
    }
}
