using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDubucks.ViewModels
{
    public class TestPageViewModel : ViewModelBase
    {
        public TestPageViewModel(INavigationService navigationService)
        : base(navigationService)
        {
            Title = "TestPageVIewModel";
        }
        public override void OnNavigatedTo(INavigationParameters parameters)
        {

        }
    }
}
