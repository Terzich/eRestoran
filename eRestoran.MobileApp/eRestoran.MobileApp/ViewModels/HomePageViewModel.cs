using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eRestoran.MobileApp.ViewModels
{
    public class HomePageViewModel : BaseViewModel
    {
        private readonly APIService _apiServiceR = new APIService("Restaurant");

        public HomePageViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        string Username = string.Empty;
        public string _Username
        {
            get { return APIService._Username; }

        }
        Model.Restaurant restaurant;

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            restaurant = await _apiServiceR.GetById<Model.Restaurant>(1);
        }

    }

}
