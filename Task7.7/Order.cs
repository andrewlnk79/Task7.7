using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7._7
{
    internal class Order<T,S,U>
    {
        private int OrderId { get; set; }
        private T List{ get; set; }
        private S buyer { get; set; }
        private U delivery { get; set; }


        public Order(int orderId, T list, S buyer, U delivery)
        {
            OrderId = orderId;
            List = list;
            this.buyer = buyer;
            this.delivery = delivery;
        }
        void deliveryInfo(U delivery)
        {
            Console.WriteLine(delivery.ToString); delivery.ToString
        }
    }

}
