using eRestoran.MobileApp.Views;
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
            RecommendationCommand = new Command(async () => await Recommendation());

        }


        public string _Username
        {
            get { return APIService._Username; }

        }
        
        string RestaurantName = string.Empty;
        public string _RestaurantName
        {
            get { return RestaurantName; }
            set { SetProperty(ref RestaurantName, value); }
        }
        
        string CityName = string.Empty;
        public string _CityName
        {
            get { return CityName; }
            set { SetProperty(ref CityName, value); }
        }
        
        string Address = string.Empty;
        public string _Address
        {
            get { return Address; }
            set { SetProperty(ref Address, value); }
        }

        int? NumberOfTables = 0;
        public int? _NumberOfTables
        {
            get { return NumberOfTables; }
            set { SetProperty(ref NumberOfTables, value); }
        }

        TimeSpan? OpenAt = null;
        public TimeSpan? _OpenAt
        {
            get { return OpenAt; }
            set { SetProperty(ref OpenAt, value); }
        }

        TimeSpan? CloseAt = null;
        public TimeSpan? _CloseAt
        {
            get { return CloseAt; }
            set { SetProperty(ref CloseAt, value); }
        }


        public ICommand InitCommand { get; set; }
        public ICommand RecommendationCommand { get; set; }

        public async Task Recommendation()
        {
            Application.Current.MainPage = new AddRecommendation();


        }

        public async Task Init()
        {
            Model.Restaurant r = await _apiServiceR.GetById<Model.Restaurant>(1);
            _RestaurantName = r.RestaurantName;
            _CityName = r.CityName;
            _Address = r.Address;
            _NumberOfTables = r.NumberOfTables;
            _OpenAt = new TimeSpan(r.OpenAt.Value.Hour, r.OpenAt.Value.Minute, r.OpenAt.Value.Second);
            _CloseAt = new TimeSpan(r.CloseAt.Value.Hour, r.CloseAt.Value.Minute, r.CloseAt.Value.Second);

        }

    }

}
