using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;
using VemaelCatalogo.Services;

namespace VemaelCatalogo.ViewModels
{
   public class CategoryDetailViewModel : Screen
    {
        private readonly ICategoriesService _categoriesService;
        private readonly INavigationService _navigationService;

        public Guid Parameter { get; set; }

        private Guid _id;

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                NotifyOfPropertyChange(() => Name);
            }
        }

        public CategoryDetailViewModel(ICategoriesService categoriesService, INavigationService navigationService)
        {
            _categoriesService = categoriesService;
            _navigationService = navigationService;
        }

        protected override void OnInitialize()
        {
            base.OnInitialize();
            LoadCategories();
        }

        private void LoadCategories()
        {
            var category = _categoriesService.GetCategory(Parameter);
            if (category == null)
            {
                _id = Guid.Empty;
            }
            else
            {
                _id = category.Id;
                Name = category.Name;
            }
        }

        public void Back()
        {
            _navigationService.GoBack();
        }

        public bool CanBack()
        {
            return _navigationService.CanGoBack;
        }
    }
}
