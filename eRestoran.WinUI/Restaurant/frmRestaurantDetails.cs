using eRestoran.Model.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eRestoran.WinUI.Restaurant
{
    public partial class frmRestaurantDetails : Form
    {
        private int _RestaurantId = 1;
        private readonly APIService _service = new APIService("Restaurant");
        private readonly APIService _serviceC = new APIService("City");

        public frmRestaurantDetails(int id=1)
        {
            InitializeComponent();
            _RestaurantId = id;
        }

        private async void RestaurantDetails_Load(object sender, EventArgs e)
        {
            LoadCity();
            var restaurant = await _service.GetById<Model.Restaurant>(_RestaurantId);
            txtRestaurantName.Text = restaurant.RestaurantName;
            txtCity.Text = restaurant.CityName;
            txtAddress.Text = restaurant.Address;
            nudNumberOfTables.Text = restaurant.NumberOfTables.ToString();
            request.Image = restaurant.Image;


            pbR.Image = System.Drawing.Image.FromStream(new MemoryStream(restaurant.Image));
            

            if (restaurant.OpenAt != null)
            {
                
                dtpOpenAt.Value = restaurant.OpenAt.Value;
            }
            else
            {
                DateTime alternateTime = new DateTime(1753,1,1,1,1,1);
                dtpOpenAt.Value = alternateTime;
            }
            if (restaurant.CloseAt != null)
            {

                dtpCloseAt.Value = restaurant.CloseAt.Value;
            }
            else
            {
                DateTime alternateTime = new DateTime(1753, 1, 1, 1, 1, 1);
                dtpCloseAt.Value = alternateTime;
            }

        }
        private async Task LoadCity()
        {
            var q = await _serviceC.Get<List<Model.City>>(null);
            q.Insert(0, new Model.City { CityId=-1, CityName="Bez promjene"});
            cmbCity.DisplayMember = "CityName";
            cmbCity.ValueMember = "CityId";
            cmbCity.DataSource = q;
        }

        RestaurantUpdateRequest request = new RestaurantUpdateRequest();
        private async void btnSave_Click(object sender, EventArgs e)
        {
            var r = await _service.GetById<Model.Restaurant>(_RestaurantId);
            DateTime openAt = dtpOpenAt.Value;
            if (int.TryParse(cmbCity.SelectedValue.ToString(), out int id))
                if (id == -1)
                    request.CityId = r.CityId;
                else request.CityId = id;

            request.RestaurantName = txtRestaurantName.Text;
            request.Address = txtAddress.Text;
            request.NumberOfTables = int.Parse(nudNumberOfTables.Text);
            request.OpenAt = openAt;
            request.CloseAt = dtpCloseAt.Value;
            

            Model.Restaurant entity = null;
            entity=await _service.Update<Model.Restaurant>(_RestaurantId, request);

            if(entity!=null)
                MessageBox.Show("Podaci restorana uspjesno promjenjeni!");
            
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtSlika.Text = openFileDialog1.FileName;
                Image originalImage = System.Drawing.Image.FromFile(openFileDialog1.FileName);
                pbR.Image = originalImage;
                MemoryStream ms = new MemoryStream();
                originalImage.Save(ms, ImageFormat.Jpeg);

                request.Image = ms.ToArray();

            }

        }

        private void txtRestaurantName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRestaurantName.Text))
            {
                errorProvider1.SetError(txtRestaurantName, Properties.Resources.Validation_Field_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtRestaurantName, null);

            }
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                errorProvider1.SetError(txtAddress, Properties.Resources.Validation_Field_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtAddress, null);

            }

        }
    }
}
