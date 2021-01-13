using DDubucks.ViewModels;
using DDubucks.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace DDubucks.Views
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
        }

    }
}
