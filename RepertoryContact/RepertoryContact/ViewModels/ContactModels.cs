using RepertoryContact.Models;
using RepertoryContact.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace RepertoryContact.ViewModels
{
    public class ContactModels : ViewModel
    {

        public ObservableCollection<Item> Items { get; set; } = new ObservableCollection<Item>();

        public RelayCommand AddContact => new RelayCommand(execute => Add());
        private Item selectedItem = null;
        public Item SelectedItem
        {
            get { return selectedItem; }
            set { selectedItem = value; OnPropertyChanged(); }   
        }

        public ContactModels()
        {
            InitContacts();
        }


        void InitContacts()
        {
            Items = new ObservableCollection<Item>();
            Items.Add(new Item { Surname = "Light", Firstname = "Papami", Email = "Mr.Popo@gmail.com" });
            Items.Add(new Item { Surname = "Floupy", Firstname = "Outch", Email = "Floup956@gmail.com" });
        }

        void Add()
        {
           // MessageBox.Show("pop");
           Window _w = new Window();   
            _w.Show();
        }
    }
}
