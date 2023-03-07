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
        private double Totalprice(List<Product> productList)
        {
            var tempPrice = 0.0;
            foreach (var product in productList)
            {
                if (product.GetPrice() != 0)
                {
                    tempPrice += product.GetPrice();
                }

            }
            return tempPrice;
        }

        




    }
}
