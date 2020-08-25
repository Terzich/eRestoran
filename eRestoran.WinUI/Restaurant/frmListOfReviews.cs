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
    public partial class frmListOfReviews : Form
    {
        private readonly APIService _serviceRR = new APIService("RestaurantReview");

        public frmListOfReviews()
        {
            InitializeComponent();
        }

        private async void frmListOfReviews_Load(object sender, EventArgs e)
        {
            var rez = await _serviceRR.Get<List<Model.RestaurantReview>>(null);
            txtNumberOfReviews.Text = rez.Count.ToString();
            dataGridView1.DataSource = rez;
        }
    }
}
