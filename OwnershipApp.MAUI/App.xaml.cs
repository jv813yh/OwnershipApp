﻿using OwnershipApp.MAUI.Views;

namespace OwnershipApp.MAUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LandingPage());
        }
    }
}
