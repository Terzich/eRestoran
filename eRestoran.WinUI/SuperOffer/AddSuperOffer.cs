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
        APIService _serviceDT = new APIService("DiscountType");



        public AddSuperOffer()
        {
            InitializeComponent();
        }

        private void AddSuperOffer_Load(object sender, EventArgs e)
        {
            LoadType();
        }
        
        private async Task LoadType()
        {
            var result = await _serviceDT.Get<List<Model.DiscountType>>(null);
            result.Insert(0, new Model.DiscountType {Description="Prilagođena super ponuda",DiscountTypeId=-1 });
            cmbType.DisplayMember = "Description";
            cmbType.ValueMember = "DiscountTypeId";
            cmbType.DataSource = result;
        }



        


        private async void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idobj = cmbType.SelectedValue;
            if (int.TryParse(idobj.ToString(), out int id))
                if (id == 14)
                    await LoadRestaurantMenuItem();
            if (id == -1)
                MessageBox.Show("Za prilagođenu super ponudu dovoljno je unijeti samo tekst ponude, datum početka i kraja!", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private async Task LoadRestaurantMenuItem()
        {
            var result = await _serviceRMI.Get<List<Model.RestaurantMenuItem>>(null);

            dgvProducts.DataSource = result;
        }

        private SuperOfferUpsertRequest CreateRequest(int id)
        {
            var req = new SuperOfferUpsertRequest
            {
                Active = true,
                OfferStart = dtpOfferStart.Value,
                OfferEnd = dtpOfferEnd.Value,
                Description=txtSuperOfferName.Text,
                DiscountValue=nudDiscount.Value


            };
            if (id > 0)
                req.DiscountType = id;
            if (id == 1)
                req.ItemTypeId = 1;
            else if (id == 2)
                req.ItemTypeId = 2;
            else if (id == 3)
                req.ItemCategoryId = 1;
            else if (id == 4)
                req.ItemCategoryId = 2;
            else if (id == 5)
                req.ItemCategoryId = 3;
            else if (id == 6)
                req.ItemCategoryId = 5;
            else if (id == 7)
                req.ItemCategoryId = 6;
            else if (id == 8)
                req.ItemCategoryId = 7;
            else if (id == 9)
                req.ItemCategoryId = 8;
            else if (id == 10)
                req.ItemCategoryId = 10;
            else if (id == 11)
                req.ItemCategoryId = 11;

            return req;

        }


        private async void button1_Click(object sender, EventArgs e)
        {
            var idobj = cmbType.SelectedValue;
            if (int.TryParse(idobj.ToString(), out int id))
            {

                if (id != 14)
                {
                    SuperOfferUpsertRequest req = CreateRequest(id);
                    Model.SuperOffer r = null;
                    r = await _serviceSO.Insert<Model.SuperOffer>(req);
                    if (r != null)
                        MessageBox.Show("Super ponuda uspješno dodana!", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Izabrali ste popust na pojedinačnu stavku." +
                        "Molimo vas da pritisnete dugme za dodavanje popusta pored stavke za koju" +
                        " želite dodijeliti popust!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private async void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProducts.Columns[e.ColumnIndex].Name == "Akcija")
            {
                var idobj = cmbType.SelectedValue;
                if (int.TryParse(idobj.ToString(), out int id))
                {
                    if (id == 14)
                    {
                        var objRMI = dgvProducts.Rows[e.RowIndex].Cells[1].Value.ToString();
                        int rmiId = int.Parse(objRMI);
                        var req = new SuperOfferUpsertRequest
                        {
                            Active = true,
                            OfferStart = dtpOfferStart.Value,
                            OfferEnd = dtpOfferEnd.Value,
                            DiscountValue = nudDiscount.Value,
                            DiscountType = id,
                            RestaurantMenuItemId = rmiId,
                            Description=txtSuperOfferName.Text
                        };
                        Model.SuperOffer r = null;
                        r = await _serviceSO.Insert<Model.SuperOffer>(req);
                        if (r != null)
                            MessageBox.Show("Super ponuda uspješno dodana!", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
