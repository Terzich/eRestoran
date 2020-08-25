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
    public partial class frmListOfRecommendation : Form
    {
        private readonly APIService _serviceVR = new APIService("VisitorRecommendation");

        public frmListOfRecommendation()
        {
            InitializeComponent();
        }

        private async void frmListOfRecommendation_Load(object sender, EventArgs e)
        {
            var rez = await _serviceVR.Get<List<Model.VisitorRecommendation>>(null);
            txtNumberOfVisits.Text = rez.Count.ToString();
            dgvRecommendations.DataSource = rez;
        }
    }
}
