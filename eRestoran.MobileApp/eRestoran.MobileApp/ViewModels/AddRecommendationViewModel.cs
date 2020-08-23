using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.MobileApp.ViewModels
{
    public class AddRecommendationViewModel:BaseViewModel
    {
        string Description = string.Empty;
        public string _Description
        {
            get { return Description; }
            set { SetProperty(ref Description, value); }
        }
    }
}
