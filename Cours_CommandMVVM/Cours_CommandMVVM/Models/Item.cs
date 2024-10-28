using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cours_CommandMVVM.Models
{
    public class Item //=> POCO : Plain old class Object that is just for storage:business
    {
        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public int Quantity { get; set; }
    }
}
