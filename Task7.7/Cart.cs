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
        private double TotalPrice { get ; set; }

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

        

        
        
    }
}
