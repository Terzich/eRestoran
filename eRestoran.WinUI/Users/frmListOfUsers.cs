using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eRestoran.Model.Request;
using eRestoran.WinUI.Award;
using Flurl.Http;

namespace eRestoran.WinUI.Users
{
    public partial class frmListOfUsers : Form
    {
        private readonly APIService _apiService = new APIService("User");
        private readonly APIService _apiServiceUR = new APIService("UserRole");

        public frmListOfUsers()
        {
            InitializeComponent();
        }

        private async void btnShowUsers_Click(object sender, EventArgs e)
        {
            var search = new UserSearchRequest()
            {
                Name = searchBox.Text
            };


            var result= await _apiService.Get<List<Model.Visitor>>(search);
            var listUR = await _apiServiceUR.Get<List<Model.VisitorRole>>(null);
            List<Model.Visitor> listV = new List<Model.Visitor>();
            int c = 0;
            foreach(var r in result)
            {
                foreach(var ur in listUR)
                {
                    if (r.UserID == ur.UserId && ur.RoleId == 2)
                        c++;
                }
                if (c > 0)
                    listV.Add(r);
                c = 0;
            }
            dgvUsers.AutoGenerateColumns = false;
            dgvUsers.DataSource = listV;
        }

        private void dgvUsers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvUsers.SelectedRows[0].Cells[0].Value;
            frmUserDetails frm = new frmUserDetails(int.Parse(id.ToString()));
            frm.Show();
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvUsers.Columns[e.ColumnIndex].Name=="AddAward")
            {
                var id = dgvUsers.Rows[e.RowIndex].Cells[0].Value;
                frmAddAward frm = new frmAddAward(int.Parse(id.ToString()));
                frm.Show();
            }
        }
    }   
}
