using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDubucks.ViewModels
{
    public class AppShellViewModel : ViewModelBase
    {
        public AppShellViewModel(INavigationService navigationService)
        : base(navigationService)
        {
            Title = "AppShellView";
        }
        public override void OnNavigatedTo(INavigationParameters parameters)
        {

        }
    }
}
