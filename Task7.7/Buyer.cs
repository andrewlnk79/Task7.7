using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7._7
{
    internal abstract class Buyer
    {
        protected string Name { get; set; }
        protected string ContactPhone { get; set; }
        protected string Email { get; set; }
        protected string Adress { get; set; }
        public string GetName() { return Name; }
        public string GetContactPhone() { return ContactPhone; }
        public string GetEmail() { return Email; }
        public string GetAdress() { return Adress; }

        protected Buyer(string name, string contactPhone, string email, string adress)
        {
            Name = name;
            ContactPhone = contactPhone;
            Email = email;
            Adress = adress;
        }
    }
}
