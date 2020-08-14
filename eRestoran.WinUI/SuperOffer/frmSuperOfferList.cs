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
    public partial class frmSuperOfferList : Form
    {
        APIService _serviceSO = new APIService("SuperOffer");

        public frmSuperOfferList()
        {
            InitializeComponent();
        }

        private async void frmSuperOfferList_Load(object sender, EventArgs e)
        {
            var data = await _serviceSO.Get<List<Model.SuperOffer>>(null);
            dgvOffers.DataSource = data;
            
        }
    }
}
