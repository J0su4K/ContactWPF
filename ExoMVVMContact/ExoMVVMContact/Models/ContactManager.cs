using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoMVVMContact.Models
{
    public class ContactManager
    {
        public static Action<Contact> OnContactAdded = null;
        public static ObservableCollection<Contact> Contacts { get; set; } = new ObservableCollection<Contact>();
    }
}
