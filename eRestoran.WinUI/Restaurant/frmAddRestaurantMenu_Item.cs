using eRestoran.Model.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        APIService _serviceRMI = new APIService("RestaurantMenuItem");


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

        private async void txtCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = txtCategory.SelectedValue;
            if(int.TryParse(idObj.ToString(),out int id))
            {
                await LoadRestaurantMenuItem(id);
            }


        }
        private async Task LoadRestaurantMenuItem(int CategoryId)
        {
            var result = await _serviceRMI.Get<List<Model.RestaurantMenuItem>>(new 
                Model.Request.MenuItemSearchRequest { ItemCategoryId = CategoryId });

            dgvItems.DataSource = result;
        }

        RestaurantMenuItemUpsertRequest request = new RestaurantMenuItemUpsertRequest();
        private async void button1_Click(object sender, EventArgs e)
        {
            var idObjC = txtCategory.SelectedValue;
            if (int.TryParse(idObjC.ToString(), out int idC))
            {
                request.ItemCategoryId = idC;
            }
            var idObjQ = txtPortion.SelectedValue;
            if (int.TryParse(idObjQ.ToString(), out int idQ))
            {
                request.QuantityId = idQ;
            }
            request.ItemName = txtItemName.Text;
            request.Price = nudPrice.Value;

            await _serviceRMI.Insert<Model.RestaurantMenuItem>(request);

        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if(result ==DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                var file = File.ReadAllBytes(fileName);
                request.Image = file;
                txtSlika.Text = fileName;
            }
        }
    }
}
