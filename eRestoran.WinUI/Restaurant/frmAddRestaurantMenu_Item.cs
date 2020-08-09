using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eRestoran.WinUI.Restaurant
{
    public partial class frmAddRestaurantMenu_Item : Form
    {
        APIService _serviceQ = new APIService("Quantity");
        APIService _serviceC = new APIService("ItemCategory");

        public frmAddRestaurantMenu_Item()
        {
            InitializeComponent();
        }

        private void frmAddRestaurantMenu_Item_Load(object sender, EventArgs e)
        {
            LoadQuantity();
            LoadCategory();

        }
        private async Task LoadQuantity()
        {
            var q = await _serviceQ.Get<List<Model.Quantity>>(null);
            q.Insert(0, new Model.Quantity());
            txtPortion.DisplayMember = "Description";
            txtPortion.ValueMember = "QuantityId";
            txtPortion.DataSource = q;
        }
        private async Task LoadCategory()
        {
            var q = await _serviceC.Get<List<Model.ItemCategory>>(null);
            q.Insert(0, new Model.ItemCategory());
            txtCategory.DisplayMember = "Category";
            txtCategory.ValueMember = "ItemCategoryId";
            txtCategory.DataSource = q;
        }
    }
}
