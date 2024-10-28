using ExoMVVMContact.Models;
using ExoMVVMContact.Utils;
using ExoMVVMContact.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ExoMVVMContact.ModelView
{
    public class MainWindowModelView : ModelViewBase
    {
        public ObservableCollection<Contact> Contacts { get; set; } = new ObservableCollection<Contact>();


        public RelayCommand OpenContactWindowCommand => new RelayCommand(OpenWindow);




        public MainWindowModelView()
        {
            ContactManager.OnContactAdded += Contacts.Add;
            Contacts.Add(new Contact { Name = "Dio" , FirstName = "Brando" , Email = "KingVampireDio@gmail.com"});
            Contacts.Add(new Contact { Name = "Jotaro", FirstName = "Joestar", Email = "JoGoatPlatinium@gmail.com" });
            Contacts.Add(new Contact { Name = "Bucciaratti", FirstName = "g zaper wsh", Email = "StickyFinger@gmail.com" });
            ContactManager.Contacts = Contacts;
        }

        void OpenWindow(object _obj)
        {
            Window _window = (Window)_obj;
            if (_window == null)
            {
                MessageBox.Show("toto");
                return;
            }
            AddContactWindow _addContactWindow = new AddContactWindow();
            _addContactWindow.Owner = _window;
            _addContactWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            _addContactWindow.Show();
        }
    }
}
