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
    public partial class ItemDetailsPage : ContentPage
    {
        private ItemDetailsViewModel model = null;
        private int itemId;
        public ItemDetailsPage(int id)
        {
            InitializeComponent();
            BindingContext = model = new ItemDetailsViewModel();
            itemId = id;
            
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.OnLoad(itemId);
        }
    }
}