using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;

namespace VemaelCatalogo.ViewModels
{
    public class MainPageViewModel : Screen
    {
        public MainPageViewModel()
        {
            _defaultText = "Esto es un texto de prueba a ver si sale";
        }

        private string  _defaultText;
        public string DefaultText
        {
            get { return _defaultText; }
            set
            {
                _defaultText = value;
                NotifyOfPropertyChange(() => DefaultText);
            }
        }
    }
}
