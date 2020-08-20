using eRestoran.MobileApp.Views;
using eRestoran.Model.Request;
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
        private readonly APIService _apiServiceUser = new APIService("User");

        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await Login());
            TapCommand = new Command(async () => CreateAccount());
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
        public ICommand TapCommand { get; set; }

        async Task CreateAccount()
        {
            Application.Current.MainPage = new CreateAccountPage();
        }

        async Task Login()
        {
            if (string.IsNullOrEmpty(_Username) || string.IsNullOrEmpty(_Password))
            {
                await Application.Current.MainPage.DisplayAlert("Greška!", "Potrebno je unijeti sva polja!", "Try again");
                return;
            }
            IsBusy = true;
            APIService._Username = _Username;
            APIService._Password = _Password;
            try
            {
                List<Model.User> usrList = await _apiServiceUser.Get<List<Model.User>>(new
                    UserSearchRequest
                { Username = _Username });
                if(usrList.Count==0)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška!", "Unijeli ste nepostojeće korisničko ime ili lozinku!", "Try again");
                    return;
                }
                foreach (var item in usrList)
                {
                    if (item.Username == _Username)
                        APIService._VisitorId = item.UserID;
                }

                Application.Current.MainPage = new MainPage();

            }
            catch (Exception ex)
            {
                IsBusy = false;
                await Application.Current.MainPage.DisplayAlert("Greška!", "Unijeli ste nepostojeće korisničko ime ili lozinku!", "Try again");

            }

        }

    }
}
