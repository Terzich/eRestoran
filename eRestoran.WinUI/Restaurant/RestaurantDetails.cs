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
    public partial class RestaurantDetails : Form
    {
        private int _RestaurantId = 1;
        private readonly APIService _service = new APIService("Restaurant");
        public RestaurantDetails(int id=1)
        {
            InitializeComponent();
            _RestaurantId = id;
        }

        private void RestaurantDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
