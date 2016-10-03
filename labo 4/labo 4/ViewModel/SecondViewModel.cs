using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using labo_4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace labo_4.ViewModel
{
    class SecondViewModel
    {
        public Student SelectedStudent { get; set; }

        private INavigationService _navigationService;

        [PreferredConstructor]
        public SecondViewModel(INavigationService navigationService = null)
        {
            _navigationService = navigationService;
        }
    }
}
