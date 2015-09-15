using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;
using VemaelCatalogo.Models;
using VemaelCatalogo.Services;

namespace VemaelCatalogo.ViewModels
{
    public class CategoryListViewModel : Screen
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }

        public CategoryListViewModel(Category category)
        {
            Id = category.Id;
            Name = category.Name;
        }        
    }
}
