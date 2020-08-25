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
    public partial class frmShowRestaurantMenuItems : Form
    {
        APIService _serviceRMI = new APIService("RestaurantMenuItem");
        APIService _serviceC = new APIService("ItemCategory");


        public frmShowRestaurantMenuItems()
        {
            InitializeComponent();
        }

        private async void frmShowRestaurantMenuItems_Load(object sender, EventArgs e)
        {
            LoadCategory();
            var rez = _serviceRMI.Get<List<Model.RestaurantMenuItem>>(null);
            dataGridView1.DataSource = rez;

        }
        private async Task LoadCategory()
        {
            var q = await _serviceC.Get<List<Model.ItemCategory>>(null);
            q.Insert(0, new Model.ItemCategory { ItemCategoryId=-1,Category="Sve stavke menija"});
            cmbCategory.DisplayMember = "Category";
            cmbCategory.ValueMember = "ItemCategoryId";
            cmbCategory.DataSource = q;
        }

        private async void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbCategory.SelectedValue;
            if (int.TryParse(idObj.ToString(), out int id))
            {
                await LoadRestaurantMenuItem(id);
            }
        }

        private async Task LoadRestaurantMenuItem(int CategoryId)
        {
            var result = await _serviceRMI.Get<List<Model.RestaurantMenuItem>>(new
                Model.Request.MenuItemSearchRequest
            { ItemCategoryId = CategoryId });

            dataGridView1.DataSource = result;
        }
    }
}
