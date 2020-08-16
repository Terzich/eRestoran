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

namespace eRestoran.WinUI.Award
{
    public partial class frmAddDiscount : Form
    {
        private int? _id = null;
        private readonly APIService _apiServiceU = new APIService("User");
        private readonly APIService _apiServiceDT = new APIService("DiscountType");
        private readonly APIService _apiServiceD = new APIService("Discount");
        private readonly APIService _apiServiceRMI = new APIService("RestaurantMenuItem");




        public frmAddDiscount(int? userId = null)
        {
            InitializeComponent();
            _id = userId;
        }

        private void frmAddDiscount_Load(object sender, EventArgs e)
        {
            LoadVisitorName();
            LoadDiscountType();
        }
        private async Task LoadVisitorName()
        {
            var result = await _apiServiceU.GetById<Model.User>(_id);
            txtVisitorName.Text = result.Name + " " + result.Surname;
        }
        private async Task LoadDiscountType()
        {
            var result = await _apiServiceDT.Get<List<Model.DiscountType>>(null);
            result.Insert(0,new Model.DiscountType());
            cmbDT.DisplayMember = "Description";
            cmbDT.ValueMember = "DiscountTypeId";
            cmbDT.DataSource = result;
        }

        private async void cmbDT_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idobj = cmbDT.SelectedValue;
            if (int.TryParse(idobj.ToString(), out int id))
                if (id == 14)
                    await LoadRestaurantMenuItems();

        }
        private async Task LoadRestaurantMenuItems()
        {
            var result = await _apiServiceRMI.Get<List<Model.RestaurantMenuItem>>(null);

            dgvItems.DataSource= result;
        }

        private DiscountUpsertRequest CreateRequest(int id)
        {
            var req = new DiscountUpsertRequest
            {
                UserId = _id.Value,
                Active = true,
                DiscountDate = DateTime.Now,
                DiscountValue = nudDV.Value,
                DiscountTypeId = id,

            };
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
            var idobj = cmbDT.SelectedValue;
            if (int.TryParse(idobj.ToString(), out int id))
            {

                if(id!=14)
                {
                    DiscountUpsertRequest req = CreateRequest(id);
                    Model.Discount r = null;
                    r = await _apiServiceD.Insert<Model.Discount>(req);
                    if (r != null)
                        MessageBox.Show("Popust uspješno dodan!", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Izabrali ste popust na pojedinačnu stavku." +
                        "Molimo vas da pritisnete dugme za dodavanje popusta pored stavke za koju" +
                        " želite dodijeliti popust!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private async void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvItems.Columns[e.ColumnIndex].Name == "AddDiscount")
            {
                var idobj = cmbDT.SelectedValue;
                if (int.TryParse(idobj.ToString(), out int id))
                {
                    if (id == 14)
                    {
                        var objRMI = dgvItems.Rows[e.RowIndex].Cells[0].Value.ToString();
                        int rmiId = int.Parse(objRMI);
                        var req = new DiscountUpsertRequest
                        {
                            UserId = _id.Value,
                            Active = true,
                            DiscountDate = DateTime.Now,
                            DiscountValue = nudDV.Value,
                            DiscountTypeId = id,
                            RestaurantMenuItemId=rmiId
                        };
                        Model.Discount r = null;
                        r = await _apiServiceD.Insert<Model.Discount>(req);
                        if (r != null)
                            MessageBox.Show("Popust uspješno dodan!", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
