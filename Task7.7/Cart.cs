using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7._7
{
    internal class Cart
    {
        //Нет метода TotalCount
        private int TotalCount { get; set; }
        private double TotalPrice = 0.0;
        public double GetTotalPrice() { return TotalPrice; }
       public List<Product> productsList { get; set; }= new List<Product>();
        public Cart() { }

        public Cart(int totalCount, double totalPrice)
        {
            TotalCount = totalCount;
            TotalPrice = totalPrice;
        }
        
        public List<Product> AddProduct<T>(T product) where T : Product
        {
            
            productsList.Add(product);
            return productsList;

        }

        private double Totalprice(List<Product> productList)
        {
            
            foreach (var product in productList)
            {
                TotalPrice += product.GetPrice();

            }
            return TotalPrice;
        }

        public void CartContains(List<Product> productList)
        {
            foreach(var product in productList)
                Console.WriteLine(product);
        }
        




    }
}
