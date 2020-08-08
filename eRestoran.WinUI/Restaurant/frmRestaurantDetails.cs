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

namespace eRestoran.WinUI.Restaurant
{
    public partial class frmRestaurantDetails : Form
    {
        private int _RestaurantId = 1;
        private readonly APIService _service = new APIService("Restaurant");
        public frmRestaurantDetails(int id=1)
        {
            InitializeComponent();
            _RestaurantId = id;
        }

        private async void RestaurantDetails_Load(object sender, EventArgs e)
        {
            var restaurant = await _service.GetById<Model.Restaurant>(_RestaurantId);
            txtRestaurantName.Text = restaurant.RestaurantName;
            txtCity.Text = restaurant.CityName;
            txtAddress.Text = restaurant.Address;
            txtNumberOfTables.Text = restaurant.NumberOfTables.ToString();
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

        private async void btnSave_Click(object sender, EventArgs e)
        {
            DateTime openAt = dtpOpenAt.Value;
            RestaurantUpdateRequest request = new RestaurantUpdateRequest
            {
                RestaurantName=txtRestaurantName.Text,
                Address=txtAddress.Text,
                NumberOfTables=int.Parse(txtNumberOfTables.Text),
                OpenAt=openAt,
                CloseAt=dtpCloseAt.Value
            };

            Model.Restaurant entity = null;
            entity=await _service.Update<Model.Restaurant>(_RestaurantId, request);

            if(entity!=null)
                MessageBox.Show("Podaci restorana uspjesno promjenjeni!");
            
        }
    }
}
