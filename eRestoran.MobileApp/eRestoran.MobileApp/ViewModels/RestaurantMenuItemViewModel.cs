using eRestoran.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using eRestoran.Model.Request;

namespace eRestoran.MobileApp.ViewModels
{
    public class RestaurantMenuItemViewModel:BaseViewModel
    {
        private readonly APIService _apiServiceRMI = new APIService("RestaurantMenuItem");
        private readonly APIService _apiServiceIC = new APIService("ItemCategory");

        public RestaurantMenuItemViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<RestaurantMenuItem> ItemList { get; set; } = new ObservableCollection<RestaurantMenuItem>();
        public ObservableCollection<ItemCategory> ItemCategoryList { get; set; } = new ObservableCollection<ItemCategory>();

        ItemCategory _selectedItemCategory = null;
        public ItemCategory SelectedItemCategory
        {
            get { return _selectedItemCategory; }
            set 
            { 
                SetProperty(ref _selectedItemCategory, value);
                if (value != null)
                    InitCommand.Execute(null);
            }
        }


        public ICommand InitCommand { get; set; }
        public async Task Init()
        {

            if(ItemCategoryList.Count==0)
            {
                var listIC = await _apiServiceIC.Get<List<ItemCategory>>(null);
                foreach (var ic in listIC)
                {
                    ItemCategoryList.Add(ic);
                }
            }
            IEnumerable<RestaurantMenuItem> list = null;
            if(SelectedItemCategory!=null)
            {
                MenuItemSearchRequest req = new MenuItemSearchRequest
                {
                    ItemCategoryId=SelectedItemCategory.ItemCategoryId
                };
                list = await _apiServiceRMI.Get<IEnumerable<RestaurantMenuItem>>(req);
                ItemList.Clear();
                foreach (var item in list)
                {
                    ItemList.Add(item);

                }
            }
            else
            {
                list = await _apiServiceRMI.Get<IEnumerable<RestaurantMenuItem>>(null);
                ItemList.Clear();
                foreach (var item in list)
                {
                    ItemList.Add(item);

                }

            }
            
        }

    }
}
