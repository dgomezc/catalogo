using System;
using System.Collections.Generic;
using System.Text;

namespace VemaelCatalogo.Models
{
    public class Product
    {
        public Guid Id { get; private set; }
        public string Name { get; internal set; }
        public string Description { get; internal set; }
        public int Price { get; internal set; }

        public Product(string name, string description, int price)
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
            Price = price;
        }
    }
}
