using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VemaelCatalogo.Services;
using Windows.UI.Xaml.Controls;

namespace VemaelCatalogo.ViewModels
{
    public class MainPageViewModel : Screen
    {
        private readonly ICategoriesService _categoriesService;
        private readonly INavigationService _navigationService;

        private IEnumerable<CategoryListViewModel> _category;

        public IEnumerable<CategoryListViewModel> Category
        {
            get { return _category; }
            set
            {
                _category = value;
                NotifyOfPropertyChange(() => Category);
            }
        }

        public MainPageViewModel(ICategoriesService categoriesService, INavigationService navigationService)
        {
            _categoriesService = categoriesService;
            _navigationService = navigationService;
        }

        protected override void OnActivate()
        {
            base.OnActivate();
            Category = _categoriesService.GetCategories().Select(c => new CategoryListViewModel(c));
        }

        public void Navigate(ItemClickEventArgs args)
        {
            var category = args.ClickedItem as CategoryListViewModel;
            _navigationService.NavigateToViewModel<CategoryDetailViewModel>(category.Id);
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
