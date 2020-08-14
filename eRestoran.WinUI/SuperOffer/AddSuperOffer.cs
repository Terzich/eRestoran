using eRestoran.Model.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eRestoran.WinUI.SuperOffer
{
    public partial class AddSuperOffer : Form
    {
        APIService _serviceT = new APIService("ItemType");
        APIService _serviceC = new APIService("ItemCategory");
        APIService _serviceRMI = new APIService("RestaurantMenuItem");
        APIService _serviceSO = new APIService("SuperOffer");


        public AddSuperOffer()
        {
            InitializeComponent();
        }

        private void AddSuperOffer_Load(object sender, EventArgs e)
        {
            LoadCategory();
            LoadType();
        }
        private async Task LoadCategory()
        {
            var q = await _serviceC.Get<List<Model.ItemCategory>>(null);
            q.Insert(0, new Model.ItemCategory());
            cmbCategory.DisplayMember = "Category";
            cmbCategory.ValueMember = "ItemCategoryId";
            cmbCategory.DataSource = q;
        }
        private async Task LoadType()
        {
            var q = await _serviceT.Get<List<Model.ItemType>>(null);
            q.Insert(0, new Model.ItemType());
            cmbType.DisplayMember = "Type";
            cmbType.ValueMember = "ItemTypeId";
            cmbType.DataSource = q;
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

            dgvProducts.DataSource = result;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            SuperOfferUpsertRequest req = new SuperOfferUpsertRequest
            {
                Description=txtSuperOfferName.Text,
                OfferStart=dtpOfferStart.Value,
                OfferEnd = dtpOfferEnd.Value,
                DiscountValue=nudDiscount.Value
            };
            var idC = cmbCategory.SelectedValue;
            var idT = cmbType.SelectedValue;
            if (int.TryParse(idC.ToString(), out int idc) && idc >0)
                req.ItemCategoryId = idc;
            if (int.TryParse(idT.ToString(), out int idt) && idt > 0)
                req.ItemTypeId = idt;

            await _serviceSO.Insert<Model.SuperOffer>(req);

        }
    }
}
