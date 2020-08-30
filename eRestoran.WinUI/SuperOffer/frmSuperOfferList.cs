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

        private async void dgvOffers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOffers.Columns[e.ColumnIndex].Name == "Deactivate")
            {
                var idobj = dgvOffers.Rows[e.RowIndex].Cells[1].Value;
                var id = int.Parse(idobj.ToString());
                var offer = await _serviceSO.GetById<Model.SuperOffer>(id);
                if (offer.Active == true)
                {

                    SuperOfferUpsertRequest req = new SuperOfferUpsertRequest
                    {
                        Active = false,
                        DiscountType = offer.DiscountType,
                        RestaurantMenuItemId = offer.RestaurantMenuItemId,
                        ItemCategoryId = offer.ItemCategoryId,
                        ItemTypeId = offer.ItemTypeId,
                        OfferStart = offer.OfferStart,
                        OfferEnd = offer.OfferEnd,
                        DiscountValue = offer.DiscountValue,
                        Description=offer.Description
                    };
                    await _serviceSO.Update<Model.SuperOffer>(id, req);
                    MessageBox.Show("Super ponuda uspješno deaktivirana", "Deaktivacija super ponude", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmSuperOfferList_Load(this, null);
                }
                else
                {
                    MessageBox.Show("Super ponuda nije aktivna", "Deaktivacija super ponude", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }
    }
}
