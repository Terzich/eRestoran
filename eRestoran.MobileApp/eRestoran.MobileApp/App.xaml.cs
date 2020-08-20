using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using eRestoran.MobileApp.Services;
using eRestoran.MobileApp.Views;

namespace eRestoran.MobileApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new LoginPage();
            DependencyService.Register<Services.IMessageService, Services.MessageService>();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
