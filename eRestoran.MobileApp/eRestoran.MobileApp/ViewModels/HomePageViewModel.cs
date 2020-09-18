using eRestoran.MobileApp.Views;
using eRestoran.Model;
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
    public class HomePageViewModel : BaseViewModel
    {
        private readonly APIService _apiServiceR = new APIService("Restaurant");
        private readonly APIService _apiServiceV = new APIService("Visit");
        private readonly APIService _apiServiceVR = new APIService("VisitorRecommendation");
        private readonly APIService _apiServiceRR = new APIService("RestaurantReview");
        private readonly APIService _apiServiceD = new APIService("Discount");
        private readonly APIService _apiServiceA = new APIService("Award");
        private readonly APIService _apiServiceSO = new APIService("SuperOffer");
        private readonly APIService _apiServiceK = new APIService("Key");







        public HomePageViewModel()
        {
            InitCommand = new Command(async () => await Init());
            RecommendationCommand = new Command(async () => await Recommendation());
            OpenRecCommand = new Command(() => OpenRec());
            AddVisitCommand= new Command(async () => await AddVisit());
            GiveReviewCommand = new Command( () => GiveReview());
            AddReviewCommand = new Command(async () => await AddReview());


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

        string DiscountType = string.Empty;
        public string _DiscountType
        {
            get { return DiscountType; }
            set { SetProperty(ref DiscountType, value); }
        
        }

        public ObservableCollection<Model.SuperOffer> SuperOfferList { get; set; } = new ObservableCollection<Model.SuperOffer>();

        bool showOffers = false;
        public bool _showOffers
        {
            get { return showOffers; }
            set { SetProperty(ref showOffers, value); }
        }

        string DiscountValue = string.Empty;
        public string _DiscountValue
        {
            get { return DiscountValue; }
            set { SetProperty(ref DiscountValue, value); }
        }


        bool activeDiscount = false;
        public bool _activeDiscount
        {
            get { return activeDiscount; }
            set { SetProperty(ref activeDiscount, value); }
        }

        DateTime? DiscountDate = null;
        public DateTime? _DiscountDate
        {
            get { return DiscountDate; }
            set { SetProperty(ref DiscountDate, value); }
        }

        string AwardText = string.Empty;
        public string _AwardText
        {
            get { return AwardText; }
            set { SetProperty(ref AwardText, value); }
        }


        bool activeAward = false;
        public bool _activeAward
        {
            get { return activeAward; }
            set { SetProperty(ref activeAward, value); }
        }

        DateTime? AwardDate = null;
        public DateTime? _AwardDate
        {
            get { return AwardDate; }
            set { SetProperty(ref AwardDate, value); }
        }




        string Description = string.Empty;
        public string _Description
        {
            get { return Description; }
            set { SetProperty(ref Description, value); }
        }

        string ReviewDescription = string.Empty;
        public string _ReviewDescription
        {
            get { return ReviewDescription; }
            set { SetProperty(ref ReviewDescription, value); }
        }
        
        string ReviewGradeS = string.Empty;
        public string _ReviewGradeS
        {
            get { return ReviewGradeS; }
            set { SetProperty(ref ReviewGradeS, value); }
        }

        string Key = string.Empty;
        public string _Key
        {
            get { return Key; }
            set { SetProperty(ref Key, value); }
        }

        int? ReviewGrade = 0;
        public int? _ReviewGrade
        {
            get { return ReviewGrade; }
            set { SetProperty(ref ReviewGrade, value); }
        }

        bool addR = false;
        public bool _addR
        {
            get { return addR; }
            set { SetProperty(ref addR, value); }
        }

        bool giveR = false;
        public bool _giveR
        {
            get { return giveR; }
            set { SetProperty(ref giveR, value); }
        }

        byte[] image = null;
        public byte[] _image
        {
            get { return image; }
            set { SetProperty(ref image, value); }
        }


        bool showR = false;
        public bool _showR
        {
            get { return showR; }
            set { SetProperty(ref showR, value); }
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
        public ICommand OpenRecCommand { get; set; }
        public ICommand AddVisitCommand { get; set; }
        public ICommand GiveReviewCommand { get; set; }
        public ICommand AddReviewCommand { get; set; }

        public async Task AddReview()
        {
            if (string.IsNullOrEmpty(_ReviewDescription))
            {
                await Application.Current.MainPage.DisplayAlert("Greška!", "Potrebno je unijeti opis vašeg dojma!", "Pokušajte ponovo!");
                return;
            }
            if (string.IsNullOrEmpty(_ReviewGradeS))
            {
                await Application.Current.MainPage.DisplayAlert("Greška!", "Potrebno je unijeti ocjenu od 1 do 5!", "Pokušajte ponovo!");
                return;
            }
            if(int.TryParse(_ReviewGradeS, out int o))
            {
                if(o<1 || o>5)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška!", "Potrebno je unijeti ocjenu od 1 do 5!", "Pokušajte ponovo!");
                    return;
                }
                _ReviewGrade = o;
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Greška!", "Potrebno je unijeti ocjenu od 1 do 5!", "Pokušajte ponovo!");
                return;
            }

            RestaurantReviewUpsertRequest req = new RestaurantReviewUpsertRequest
            {
                UserId = APIService._VisitorId,
                Grade = _ReviewGrade,
                Description = _ReviewDescription
            };
            Model.RestaurantReview r = null;
            r = await _apiServiceRR.Insert<Model.RestaurantReview>(req);
            if(r!= null)
            {
                await Application.Current.MainPage.DisplayAlert("Dojam ostavljen!", "Uspješno ste ostavili dojam ovom restoranu!", "OK");
                _giveR = false;

            }



        }

        public void  GiveReview()
        {
            _giveR = true;
            _showR = false;
        }

        public async Task AddVisit()
        {

            var ks = await _apiServiceK.Get<List<Model.Key>>(null);
            bool c = false;
            int id = 0;


            if (string.IsNullOrEmpty(_Key))
            {
                await Application.Current.MainPage.DisplayAlert("Greška!", "Za ostavljanje posjete potrebno je unijeti kod od 9 cifara! (Napomena: devetocifreni kod možete zatražiti na šanku kod konobara, ukoliko nema dostupnih kodova, obavijestite osoblje restorana kako bi vam generisali novi!", "Pokušajte ponovo!");
                return;
            }
            foreach (var item in ks)
            {
                if (_Key == item.Key1.ToString())
                {
                    c = true;
                    id = item.KeyId;
                }
            }
            if(c==false)
            {
                await Application.Current.MainPage.DisplayAlert("Greška!", "Vaš kod nije ispravan!", "Pokušajte ponovo!");
                return;
            }

            KeyUpsertRequest kr = new KeyUpsertRequest { Key1 = ks[id].Key1, Active = false };
            await _apiServiceK.Update<Model.Key>(id, kr);

            VisitUpsertRequest req = new VisitUpsertRequest
            {
                UserId = APIService._VisitorId,
                DateOfVisit = DateTime.Now
            };
            Model.Visit r = null;
            r = await _apiServiceV.Insert<Model.Visit>(req);
            if(r!=null)
            {
                await Application.Current.MainPage.DisplayAlert("Posjeta ostavljena!", "Uspješno ste ostavili posjetu ovom restoranu!", "OK");
                _showR = true;
            }


        }


        public void OpenRec()
        {
            if (_addR == false)
                _addR = true;
            else
                _addR = false;
        }


        public async Task Recommendation()
        {
            
            var visits = await _apiServiceV.Get<List<Model.Visit>>(null);
            var vr = await _apiServiceVR.Get<List<Model.VisitorRecommendation>>(null);
            int c = 0, c1 = 0;

            foreach (var item in visits)
            {
                if (item.UserId == APIService._VisitorId)
                    c++;
            }
            foreach (var item in vr)
            {
                if (item.UserId == APIService._VisitorId)
                    c1++;
            }
            if(c<=c1)
                await Application.Current.MainPage.DisplayAlert("Obavijest!", "Broj preporuka ne može biti veći od broja posjeta. Nakon nove posjete resorana, ostavljanje preporuke će biti omogućeno!", "OK");
            else
            {
                if (string.IsNullOrEmpty(_Description))
                {
                    await Application.Current.MainPage.DisplayAlert("Greška!", "Potrebno je unijeti tekst preporuke!", "Pokušajte ponovo!");
                    return;
                }
                VisitorRecommendationUpsertRequest req = new VisitorRecommendationUpsertRequest
                {
                    UserId = APIService._VisitorId,
                    RecommendationDescription = _Description
                };
                Model.VisitorRecommendation r = null;
                r = await _apiServiceVR.Insert<Model.VisitorRecommendation>(req);
                if (r != null)
                {
                    await Application.Current.MainPage.DisplayAlert("Preporuka ostavljena!", "Uspješno ste ostavili preporuku ovom restoranu!", "OK");
                    _addR = false;
                }

            }
        }

        public async Task Init()
        {
            Model.Restaurant r = await _apiServiceR.GetById<Model.Restaurant>(1);
            _RestaurantName = r.RestaurantName;
            _CityName = r.CityName;
            _Address = r.Address;
            _NumberOfTables = r.NumberOfTables;
            _image = r.Image;
            _OpenAt = new TimeSpan(r.OpenAt.Value.Hour, r.OpenAt.Value.Minute, r.OpenAt.Value.Second);
            _CloseAt = new TimeSpan(r.CloseAt.Value.Hour, r.CloseAt.Value.Minute, r.CloseAt.Value.Second);
            List<Model.Discount> d = await _apiServiceD.Get<List<Model.Discount>>(null);
            List<Model.Award> a = await _apiServiceA.Get<List<Model.Award>>(null);
            List<Model.SuperOffer> s = await _apiServiceSO.Get<List<Model.SuperOffer>>(null);

            foreach (var item in d)
            {
                if (item.UserId == APIService._VisitorId)
                {
                    if (item.Active == true)
                    {
                        _activeDiscount = true;
                        _DiscountType = item.DiscountType;
                        _DiscountDate = item.DiscountDate;
                        _DiscountValue = (item.DiscountValue * 100).ToString();
                    }
                    
                }
            }
            foreach (var item in a)
            {
                if (item.UserId == APIService._VisitorId)
                {
                    if (item.Active == true)
                    {
                        _activeAward = true;
                        _AwardText= item.Description;
                        _AwardDate = item.AwardDate;
                    }

                }
            }
            foreach (var item in s)
            {
                if(item.Active == true)
                {
                    _showOffers = true;
                    SuperOfferList.Add(item);                     
                }

            }


        }

    }

}
