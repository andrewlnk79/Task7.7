using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7._7
{
    internal class Cart
    {

        private int TotalCount { get; set; }
        private double TotalPrice = 0.0;
        public double GetTotalPrice() { return TotalPrice; }

        public Cart(int totalCount, double totalPrice)
        {
            TotalCount = totalCount;
            TotalPrice = totalPrice;
        }

        private List<Product> CollectProduct<T>(T product) where T : Product
        {
            List<Product> productsList = new List<Product>();
            productsList.Add(product);
            return productsList;

        }
        private int Totalprice(List<Product> productList)
        {
            var tempPrice = 0;
            foreach (Product i in productList)
            {
                if productList()[i] == i.GetPrice() {
                    tempPrice += (int)i.GetPrice()
                        }
                return tempPrice;
            }
        }





    }
}
