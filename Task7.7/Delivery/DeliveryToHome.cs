using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7._7.Delivery
{
    internal class DeliveryToHome : Delivery
    {
        public DeliveryToHome(string adress, string name, string phone) : base(adress, name, phone)
        {

        }

        public override void MakeDelivery()
        {
            Console.WriteLine( "заказ привезет курьер");

        }
    }
}
