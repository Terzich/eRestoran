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
    public partial class frmListOfVisits : Form
    {
        private readonly APIService _serviceV = new APIService("Visit");

        public frmListOfVisits()
        {
            InitializeComponent();
        }

        private async void frmListOfVisits_Load(object sender, EventArgs e)
        {
            var rez = await _serviceV.Get<List<Model.Visit>>(null);
            txtNumberOfVisits.Text = rez.Count.ToString();
            dgvVisits.DataSource = rez;

        }
    }
}
