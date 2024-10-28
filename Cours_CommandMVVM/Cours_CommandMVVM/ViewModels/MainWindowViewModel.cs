using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Cours_CommandMVVM.Models;
using Cours_CommandMVVM.MVVM;


namespace Cours_CommandMVVM.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {

        //public RelayCommand AddCommand => new RelayCommand(execute => { }, _canExecute => { return true; }); //Premiere façon de faire
       // public RelayCommand AddCommand => new RelayCommand(execute => AddItem(), _canExecute => { return true; });
      public RelayCommand AddCommand => new RelayCommand(execute => AddItem());

        public RelayCommand DeleteCommand => new RelayCommand(execute => DeleteItem() , _canExecute => SelectedItem != null);
        public RelayCommand SaveCommand => new RelayCommand(execute => Save(), _canSave => CanSave());

        private Item selectedItem = null;

        public ObservableCollection<Item> Items { get; set; } = new ObservableCollection<Item>();

        public Item SelectedItem
        {
            get { return selectedItem; }
            set { selectedItem = value; OnPropertyChanged();}
        }

        public MainWindowViewModel()
        {
            Items = new ObservableCollection<Item>();
            Items.Add(new Item
            {
                Name = "ProductA",
                SerialNumber = "1511",
                Quantity = 7
            });

            Items.Add(new Item
            {
                Name = "ProductB",
                SerialNumber = "8875",
                Quantity = 3
            });

        }

        void AddItem()
        {
            Items.Add(new Item
            {
                Name = "New Product",
                SerialNumber = "1111",
                Quantity = 1
            });
        }

        void DeleteItem()
        {
            Items.Remove(selectedItem);
        }

        void Save()
        {
            MessageBox.Show("A ça sauvegarde direct ?!");
        }

        bool CanSave()
        {
            return Items.Count > 5;
        }
    }
}
