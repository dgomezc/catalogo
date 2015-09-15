using System;
using System.Collections.Generic;
using System.Text;
using VemaelCatalogo.Models;

namespace VemaelCatalogo.Services
{
    public interface ICategoriesService
    {
        IEnumerable<Category> GetCategories();
        Category GetCategory(Guid id);

        //void Save(Guid id, string name);
        //void Delete(Guid id);
    }
}
