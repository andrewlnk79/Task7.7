using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7._7
{
    internal abstract class Product
    {
        protected string Name { get; set; }
        protected string Description { get; set; }
        protected int Id {get; set; }
        protected double Price { get; set; }

        protected Product(string name, string description, int id, double price)
        {
            Name = name;
            Description = description;
            Id = id;
            Price = price;
        }

    }
}
