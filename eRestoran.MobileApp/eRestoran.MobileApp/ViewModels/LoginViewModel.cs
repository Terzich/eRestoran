using eRestoran.MobileApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eRestoran.MobileApp.ViewModels
{
    public class LoginViewModel:BaseViewModel
    {
        private readonly APIService _apiService=new APIService("ItemCategory");
        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await Login());
        }



        string Username = string.Empty;
        public string _Username
        {
            get { return Username; }
            set { SetProperty(ref Username, value); }
        }
        string Password = string.Empty;
        public string _Password
        {
            get { return Password; }
            set { SetProperty(ref Password, value); }
        }
        public ICommand LoginCommand { get; set; }

        async Task Login()
        {
            IsBusy = true;
            APIService._Username = _Username;
            APIService._Password = _Password;
            try
            {
                await _apiService.Get<dynamic>(null);
                Application.Current.MainPage = new MainPage();

            }
            catch (Exception ex)
            {

            }

        }

    }
}
