using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7._7
{
    internal class Order<T,S,U>
    {
        private int Id { get; set; }
        private T product{ get; set; }
        private S buyer { get; set; }
        private U delivery { get; set; }

        public Order(int id, T product, S buyer, U delivery)
        {
            Id = id;
            this.product = product;
            this.buyer = buyer;
            this.delivery = delivery;
        }
    }
}
