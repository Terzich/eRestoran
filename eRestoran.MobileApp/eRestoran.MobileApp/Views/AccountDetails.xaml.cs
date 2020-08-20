using eRestoran.MobileApp.ViewModels;
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
    public partial class AccountDetails : ContentPage
    {
        private UserInsertRequestViewModel model = null;
        
        public AccountDetails()
        {
            InitializeComponent();
            BindingContext = model = new UserInsertRequestViewModel();

        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
    }
}