using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7._7
{
    internal class Cart
    {
        private int OrderId { get; set; }
        private int TotalCount { get; set; }
        private double TotalPrice { get; set; }

        public Cart(int orderId, int totalCount, double totalPrice)
        {
            OrderId = orderId;
            TotalCount = totalCount;
            TotalPrice = totalPrice;
        }
        
        
    }
}
