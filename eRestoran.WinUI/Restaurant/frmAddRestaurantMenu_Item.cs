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
using System.Drawing.Imaging;

namespace eRestoran.WinUI.Restaurant
{
    public partial class frmAddRestaurantMenu_Item : Form
    {
        APIService _serviceQ = new APIService("Quantity");
        APIService _serviceC = new APIService("ItemCategory");
        APIService _serviceRMI = new APIService("RestaurantMenuItem");

        private int? _id = null;


        public frmAddRestaurantMenu_Item(int? rmiId = null)
        {
            InitializeComponent();
            _id = rmiId;
        }

        private async void frmAddRestaurantMenu_Item_Load(object sender, EventArgs e)
        {
            LoadQuantity();
            LoadCategory();
            if (_id.HasValue)
            {
                var rmi = await _serviceRMI.GetById<Model.RestaurantMenuItem>(_id);
                txtItemName.Text = rmi.ItemName;
                nudPrice.Value = rmi.Price;
                request.Image = rmi.Image;
                pbRMI.Image = System.Drawing.Image.FromStream(new MemoryStream(rmi.Image));
            }

        }
        private async Task LoadQuantity()
        {
            var q = await _serviceQ.Get<List<Model.Quantity>>(null);
            if (_id.HasValue)
            {
                var rmi = await _serviceRMI.GetById<Model.RestaurantMenuItem>(_id);
                q.Insert(0, new Model.Quantity { QuantityId = rmi.QuantityId.Value, Description = rmi.QuantityName });
            }
            else
            {
                q.Insert(0, new Model.Quantity());

            }
            txtPortion.DisplayMember = "Description";
            txtPortion.ValueMember = "QuantityId";
            txtPortion.DataSource = q;
        }
        private async Task LoadCategory()
        {
            var q = await _serviceC.Get<List<Model.ItemCategory>>(null);
            if (_id.HasValue)
            {
                var rmi = await _serviceRMI.GetById<Model.RestaurantMenuItem>(_id);
                q.Insert(0, new Model.ItemCategory { ItemCategoryId = rmi.ItemCategoryId, Category = rmi.ItemCategoryName});
            }
            else
            {
                q.Insert(0, new Model.ItemCategory());

            }
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
            if(this.ValidateChildren())
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

                if (_id.HasValue)
                {
                    await _serviceRMI.Update<Model.RestaurantMenuItem>(_id.Value, request);
                }
                else
                {

                    await _serviceRMI.Insert<Model.RestaurantMenuItem>(request);
                }
                MessageBox.Show("Stavka menija uspješno dodana / izmjenjena!", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
           if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                txtSlika.Text = openFileDialog1.FileName;
                Image originalImage = System.Drawing.Image.FromFile(openFileDialog1.FileName);
                pbRMI.Image = originalImage;

                MemoryStream ms = new MemoryStream();
                originalImage.Save(ms, ImageFormat.Jpeg);

                request.Image = ms.ToArray();
            }
        }

        private void txtItemName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtItemName.Text))
            {
                errorProvider1.SetError(txtItemName, Properties.Resources.Validation_Field_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtItemName, null);

            }
        }

        private void txtPortion_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPortion.Text))
            {
                errorProvider1.SetError(txtPortion, Properties.Resources.Validation_Field_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtPortion, null);

            }
        }

        private void txtCategory_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCategory.Text))
            {
                errorProvider1.SetError(txtCategory, Properties.Resources.Validation_Field_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtCategory, null);

            }
        }

        private void nudPrice_Validating(object sender, CancelEventArgs e)
        {

            if (int.TryParse(nudPrice.ToString(),out int p))
            {
                if(p<1)
                {
                    errorProvider1.SetError(nudPrice, Properties.Resources.Validation_Field_PriceTooLow);
                    e.Cancel = true;
                }
            }
            else
            {
                errorProvider1.SetError(nudPrice, null);

            }
        }

    }
    }

