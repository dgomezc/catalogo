using System;
using System.Collections.Generic;
using System.Text;

namespace VemaelCatalogo.Models
{
    public class Category
    {
        public Guid Id { get; private set; }
        public string Name { get; internal set; }
        public IEnumerable<Category> ChildrenCategories { get; internal set; }
        public IEnumerable<Product> Products { get; internal set; }

        public Category(string name, IEnumerable<Category> childrenCategories, IEnumerable<Product> products)
        {
            Id = Guid.NewGuid();
            Name = name;
            ChildrenCategories = childrenCategories;
            Products = products;
        }
    }
}
