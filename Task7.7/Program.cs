using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task7._7.Delivery;

namespace Task7._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Meat meat= new Meat("pork","cold",10,50.20);
            Fruit fruit = new Fruit("orange", "african", 12, 10.0);
            Buyer1 Nick = new Buyer1("Nick", "123456789", "e@.7u", "field#2");
            DeliveryToHome Newdelivery = new DeliveryToHome(Nick.GetAdress(), Nick.GetName(),Nick.GetContactPhone());
            Cart cart = new Cart();
            cart.AddProduct(meat);
            cart.AddProduct(fruit);
           
            

            Order order = new Order(1, productList, Nick, DeliveryToHome Newdelivery = new DeliveryToHome(Nick.GetAdress(), Nick.GetName(), Nick.GetContactPhone()));
            Console.WriteLine(order);
            Console.ReadKey();






        }
    }
}
