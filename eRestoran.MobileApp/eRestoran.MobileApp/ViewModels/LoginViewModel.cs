using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.MobileApp.ViewModels
{
    public class LoginViewModel:BaseViewModel
    {
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
    }
}
