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
    public partial class AddRecommendation : ContentPage
    {
        AddRecommendationViewModel vm;

        public AddRecommendation()
        {
            InitializeComponent();
            BindingContext = vm = new AddRecommendationViewModel();
        }
    }
}