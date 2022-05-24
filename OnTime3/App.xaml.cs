using System;
using OnTime3.Services;
using OnTime3.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OnTime3
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            //MainPage = new AppShell();
            MainPage = new NavigationPage(new Loginpage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
