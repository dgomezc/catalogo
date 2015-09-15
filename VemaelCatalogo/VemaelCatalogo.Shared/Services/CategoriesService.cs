using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VemaelCatalogo.Models;

namespace VemaelCatalogo.Services
{
    public class CategoriesService : ICategoriesService
    {
        private List<Category> _categories;

        public CategoriesService()
        {
            _categories = new List<Category>
            {
                new Category("Gama blanca", new List<Category>(), new List<Product>()),
                new Category("Gama marrón", new List<Category>(), new List<Product>()),
                new Category("Gama gris", new List<Category>(), new List<Product>()),
                new Category("Gama PAE", new List<Category>(), new List<Product>())
            };
        }

        public IEnumerable<Category> GetCategories()
        {
            return _categories;
        }

        public Category GetCategory(Guid id)
        {
            return _categories.FirstOrDefault(c => c.Id == id);
        }
    }
}
