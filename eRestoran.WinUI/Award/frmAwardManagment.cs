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
    public partial class frmAwardManagment : Form
    {
        private readonly APIService _apiServiceA = new APIService("Award");

        public frmAwardManagment()
        {
            InitializeComponent();
        }

        private async void frmAwardManagment_Load(object sender, EventArgs e)
        {
            var result = await _apiServiceA.Get<List<Model.Award>>(null);
            dgvAwardList.DataSource = result;
        }
        

        private async void dgvAwardList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAwardList.Columns[e.ColumnIndex].Name == "Deactivate")
            {
                var idobj = dgvAwardList.Rows[e.RowIndex].Cells[0].Value;
                var id = int.Parse(idobj.ToString());
                var award = await _apiServiceA.GetById<Model.Award>(id);
                if (award.Active == true)
                {

                    AwardUpsertRequest req = new AwardUpsertRequest
                    {
                        UserId = award.UserId,
                        Active = false,
                        Description = award.Description,
                        AwardDate = award.AwardDate
                    };
                    await _apiServiceA.Update<Model.Award>(id, req);
                    MessageBox.Show("Nagrada uspješno deaktivirana", "Deaktivacija nagrade", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmAwardManagment_Load(this,null);
                }
                else
                {
                    MessageBox.Show("Nagrada nije aktivna", "Deaktivacija nagrade", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }


        }

    }
}
