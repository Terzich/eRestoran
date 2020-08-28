using eRestoran.Model.Request;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eRestoran.MobileApp.ViewModels
{
    class ItemDetailsViewModel: BaseViewModel
    {
        private readonly APIService _apiServiceRMI = new APIService("RestaurantMenuItem");
        private readonly APIService _apiServiceMIR = new APIService("MenuItemsReview");
        private readonly APIService _RecommendService = new APIService("Recommend");



        public ItemDetailsViewModel()
        {
            GiveReviewCommand = new Command(() => GiveReview());
            AddGradeCommand = new Command(async () => await AddGrade());
        }



        public ObservableCollection<Model.RestaurantMenuItem> RecommendedRmItems { get; set; } = new ObservableCollection<Model.RestaurantMenuItem>();

        public ICommand GiveReviewCommand { get; set; }

        void GiveReview()
        {
            _give = true;
        }

        public ICommand AddGradeCommand { get; set; }

        async Task AddGrade()
        {
            if (string.IsNullOrEmpty(_ReviewDescription) || string.IsNullOrEmpty(_ReviewGrade))
            {
                await Application.Current.MainPage.DisplayAlert("Greška!", "Potrebno je unijeti i ocjenu i dojam!", "Pokušaj ponovo");
                return;
            }
            if(int.TryParse(_ReviewGrade, out int g))
            {
                if(g<1 || g>5)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška!", "Ocjena ne može biti veća od 5 ili manja od 1!", "Pokušaj ponovo");
                    return;
                }
                MenuItemsReviewUpsertRequest req = new MenuItemsReviewUpsertRequest
                {
                    Description = _ReviewDescription,
                    Grade = int.Parse(_ReviewGrade),
                    RestaurantMenuItemId = _RestaurantMenuItemId,
                    UserId = APIService._VisitorId
                };
                Model.MenuItemsReview r = null;
                r = await _apiServiceMIR.Insert<Model.MenuItemsReview>(req);
                if (r != null)
                {
                    await Application.Current.MainPage.DisplayAlert("Potvrda", "Uspješno ste ostavili ocjenu ovoj stavci!", "OK");
                    _give = false;
                    return;
                }


            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Greška!", "Ocjena ne može biti veća od 5 ili manja od 1!", "Pokušaj ponovo");
                return;
            }

        }


        bool give = false;
        public bool _give
        {
            get { return give; }
            set { SetProperty(ref give, value); }
        }

        string ItemName = string.Empty;
        public string _ItemName
        {
            get { return ItemName; }
            set { SetProperty(ref ItemName, value); }
        }

        string ReviewGrade = string.Empty;
        public string _ReviewGrade
        {
            get { return ReviewGrade; }
            set { SetProperty(ref ReviewGrade, value); }
        }

        string ReviewDescription = string.Empty;
        public string _ReviewDescription
        {
            get { return ReviewDescription; }
            set { SetProperty(ref ReviewDescription, value); }
        }

        decimal Price = 0;
        public decimal _Price
        {
            get { return Price; }
            set { SetProperty(ref Price, value); }
        }

        string ItemCategoryName = string.Empty;
        public string _ItemCategoryName
        {
            get { return ItemCategoryName; }
            set { SetProperty(ref ItemCategoryName, value); }
        }

        string QuantityName = string.Empty;
        public string _QuantityName
        {
            get { return QuantityName; }
            set { SetProperty(ref QuantityName, value); }
        }

        byte[] Image = null;
        public byte[] _Image
        {
            get { return Image; }
            set { SetProperty(ref Image, value); }
        }

        

        int RestaurantMenuItemId = 0;
        public int _RestaurantMenuItemId
        {
            get { return RestaurantMenuItemId; }
            set { SetProperty(ref RestaurantMenuItemId, value); }
        }

        int ItemCategoryId = 0;
        public int _ItemCategoryId
        {
            get { return ItemCategoryId; }
            set { SetProperty(ref ItemCategoryId, value); }
        }

        int? QuantityId = 0;
        public int? _QuantityId
        {
            get { return QuantityId; }
            set { SetProperty(ref QuantityId, value); }
        }


        public async Task OnLoad(int id)
        {
            var r = await _apiServiceRMI.GetById<Model.RestaurantMenuItem>(id);
            _ItemCategoryId = r.ItemCategoryId;
            _ItemName = r.ItemName;
            _RestaurantMenuItemId = r.RestaurantMenuItemId;
            _ItemCategoryName = r.ItemCategoryName;
            _QuantityId = r.QuantityId;
            _QuantityName = r.QuantityName;
            _Price = r.Price;
            _Image = r.Image;

            List<Model.RestaurantMenuItem> rec = await _RecommendService.Get<List<Model.RestaurantMenuItem>>(new RecommendedSearchRequest()
            {
                rmiID = id
            });

            RecommendedRmItems.Clear();
            foreach (var rmi in rec)
            {
                RecommendedRmItems.Add(rmi);
            }
        }
    }
}
