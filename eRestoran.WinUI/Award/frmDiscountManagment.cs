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
    public partial class frmDiscountManagment : Form
    {
        private readonly APIService _apiServiceD = new APIService("Discount");


        public frmDiscountManagment()
        {
            InitializeComponent();
        }

        private async void frmDiscountManagment_Load(object sender, EventArgs e)
        {
            var result = await _apiServiceD.Get<List<Model.Discount>>(null);
            dgvD.DataSource = result;
        }

        private async void dgvD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvD.Columns[e.ColumnIndex].Name == "DeactivateDiscount")
            {
                var idobj = dgvD.Rows[e.RowIndex].Cells[0].Value;
                var id = int.Parse(idobj.ToString());
                var discount = await _apiServiceD.GetById<Model.Discount>(id);
                if (discount.Active == true)
                {

                    DiscountUpsertRequest req = new DiscountUpsertRequest
                    {
                        UserId = discount.UserId,
                        Active = false,
                        DiscountTypeId=discount.DiscountTypeId,
                        RestaurantMenuItemId=discount.RestaurantMenuItemId,
                        ItemCategoryId=discount.ItemCategoryId,
                        ItemTypeId=discount.ItemTypeId,
                        DiscountDate=discount.DiscountDate,
                        DiscountValue=discount.DiscountValue
                    };
                    await _apiServiceD.Update<Model.Discount>(id, req);
                    MessageBox.Show("Popust uspješno deaktiviran", "Deaktivacija popusta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmDiscountManagment_Load(this, null);
                }
                else
                {
                    MessageBox.Show("Popust nije aktivan", "Deaktivacija popusta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }
    }
}
