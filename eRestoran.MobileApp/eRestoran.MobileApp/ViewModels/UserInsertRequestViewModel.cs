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

        public UserInsertRequestViewModel()
        {
            SignUpCommand = new Command(async () => await SignUp());
            BackToLoginCommand = new Command(async () => await BackToLogin());
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
        async Task BackToLogin()
        {
            Application.Current.MainPage = new LoginPage();
        }

        async Task SignUp()
        {
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
            await _service.Insert<Model.User>(req);
        }


    }
}
