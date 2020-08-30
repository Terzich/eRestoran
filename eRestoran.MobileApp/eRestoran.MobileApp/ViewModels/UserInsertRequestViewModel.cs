using eRestoran.MobileApp.Views;
using eRestoran.Model.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eRestoran.MobileApp.ViewModels
{
    public class UserInsertRequestViewModel:BaseViewModel
    {
        private readonly APIService _service = new APIService("User");

        private readonly Services.IMessageService _messageService;
        public UserInsertRequestViewModel()
        {
            this._messageService = DependencyService.Get<Services.IMessageService>();

            SignUpCommand = new Command(async () => await SignUp());
            BackToLoginCommand = new Command(async () => await BackToLogin());
            InitCommand = new Command(async () => await Init());
            ChangePassCommand = new Command( () =>  Change());
            UpdateDataCommand = new Command(async () => await UpdateData());

            


        }

        [Required]
        string Name = string.Empty;
        [Required]
        public string _Name
        {
            get { return Name; }
            set { SetProperty(ref Name, value); }
        }
        
        [Required]
        string Surname = string.Empty;
        [Required]
        public string _Surname
        {
            get { return Surname; }
            set { SetProperty(ref Surname, value); }
        }
        
        [Required]
        string Address = string.Empty;
        [Required]
        public string _Address
        {
            get { return Address; }
            set { SetProperty(ref Address, value); }
        }

        [Required]
        DateTime? DateOfBirth = null;
        [Required]
        public DateTime? _DateOfBirth
        {
            get { return DateOfBirth; }
            set { SetProperty(ref DateOfBirth, value); }
        }
        
        [Required]
        string PhoneNumber = string.Empty;
        [Required]
        public string _PhoneNumber
        {
            get { return PhoneNumber; }
            set { SetProperty(ref PhoneNumber, value); }
        }

        bool showPW = false;
        
        public bool _showPW
        {
            get { return showPW; }
            set { SetProperty(ref showPW, value); }
        }

        [Required]
        string Password = string.Empty;
        [Required]
        public string _Password
        {
            get { return Password; }
            set { SetProperty(ref Password, value); }
        }
        
        [Required]
        string ConfirmationPassword = string.Empty;
        [Required]
        public string _ConfirmationPassword
        {
            get { return ConfirmationPassword; }
            set { SetProperty(ref ConfirmationPassword, value); }
        }
        
        [Required]
        string Username = string.Empty;
        [Required]
        public string _Username
        {
            get { return Username; }
            set { SetProperty(ref Username, value); }
        }

        public ICommand SignUpCommand { get; set; }
        public ICommand BackToLoginCommand { get; set; }
        public ICommand InitCommand { get; set; }
        public ICommand ChangePassCommand { get; set; }
        public ICommand UpdateDataCommand { get; set; }

        public async Task UpdateData()
        {
            if (string.IsNullOrWhiteSpace(_Name) || string.IsNullOrWhiteSpace(_Surname) || string.IsNullOrWhiteSpace(_Address) ||
                    string.IsNullOrWhiteSpace(_PhoneNumber) || string.IsNullOrWhiteSpace(_Username) ||
                    _DateOfBirth==null)
            {
                await Application.Current.MainPage.DisplayAlert("Greška!", "Potrebno je unijeti sva polja osim polja za promjenu lozinke!", "Try again");
                return;
            }
            var users = await _service.Get<List<Model.User>>(null);
            foreach (var item in users)
            {
                if(item.Username.StartsWith(_Username) && item.Username!=APIService._Username)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška!", "Ovo korisničko ime je zauzeto!", "Try again");
                    return;
                }
            }
            if(_Username.Length<4)
            {
                await Application.Current.MainPage.DisplayAlert("Greška!", "Dužina korisničkog imena mora iznositi najmanje 4 karaktera", "Try again");
                return;
            }
            IsBusy = true;
            UserInsertRequest req = new UserInsertRequest
            {
                Name = _Name,
                Surname = _Surname,
                Address = _Address,
                DateOfBirth = _DateOfBirth,
                PhoneNumber = _PhoneNumber,
                Username = _Username
            };
            if (_showPW)
            {
                req.Password = _Password;
                req.ConfirmationPassword = _ConfirmationPassword;
            }
            else
            {
                req.Password = APIService._Password;
                req.ConfirmationPassword = APIService._Password;
            }
            APIService._Username = _Username;
            Model.Visitor r = null;
            r = await _service.Update<Model.Visitor>(APIService._VisitorId, req);
            if(r!=null)
            {
                await Application.Current.MainPage.DisplayAlert("Izmjena podataka uspješna!", "Uspješno ste promijenili vaše podatke. Za nastavak korištenja aplikacije, ponovo se logirajte!", "Ok");
                await Application.Current.MainPage.Navigation.PushModalAsync(new LoginPage());
                return;

            }


        }

        public void Change()
        {
            if (_showPW == false)
                _showPW = true;
            else
                _showPW = false;
        }
        
        public async Task Init()
        {
            Model.Visitor r = null;
            r = await _service.GetById<Model.Visitor>(APIService._VisitorId);

            if (r != null)
            {
                _Name = r.Name;
                _Surname = r.Surname;
                _Address = r.Address;
                _DateOfBirth = r.DateOfBirth;
                _PhoneNumber = r.PhoneNumber;
                _Username = r.Username;
            }
        }


        async Task BackToLogin()
        {
            Application.Current.MainPage = new LoginPage();
        }

        async Task SignUp()
        {
            if (string.IsNullOrEmpty(_Name) || string.IsNullOrEmpty(_Surname) || string.IsNullOrEmpty(_Address) || _DateOfBirth==null || string.IsNullOrEmpty(_PhoneNumber) || string.IsNullOrEmpty(_Password) || string.IsNullOrEmpty(_ConfirmationPassword) || string.IsNullOrEmpty(_Username))
            {
                await Application.Current.MainPage.DisplayAlert("Greška!", "Potrebno je unijeti sva polja!", "Try again");
                return;
            }
            IsBusy = true;
            UserInsertRequest req = new UserInsertRequest
            {
                Name=_Name,
                Surname=_Surname,
                Address=_Address,
                DateOfBirth=_DateOfBirth,
                PhoneNumber=_PhoneNumber,
                Password=_Password,
                ConfirmationPassword=_ConfirmationPassword,
                Username=_Username
            };
            Model.User r = null;
            r=await _service.Insert<Model.User>(req);
            if(r!=null)
            {
                await _messageService.ShowAsync("Kreiranje računa uspješno izvršeno, molimo logirajte se za nastavak!");
            }
        }
    }
}
