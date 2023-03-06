using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7._7
{
    internal class Delivery
    {
        private string Adress { get; set; }
        private string Name { get; set; }
        private string Phone { get; set; }

        public Delivery(string adress, string name, string phone)
        {
            Adress = adress;
            Name = name;
            Phone = phone;
        }

        
    }
}
