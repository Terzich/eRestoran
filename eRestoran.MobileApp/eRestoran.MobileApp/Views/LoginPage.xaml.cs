using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eRestoran.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        private bool? redirect = null;
        public LoginPage(bool? red=false)
        {
            InitializeComponent();
            redirect = red;
            imgDisp.Source = "reslogo.png";
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateAccountPage());
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            if(redirect==true)
                await Application.Current.MainPage.Navigation.PushModalAsync(new LoginPage());
        }
    }
}