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
using Flurl.Http;

namespace eRestoran.WinUI.Users
{
    public partial class frmListOfUsers : Form
    {
        private readonly APIService _apiService = new APIService("User");
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


            var result= await _apiService.Get<List<Model.User>>(search);
            dgvUsers.AutoGenerateColumns = false;
            dgvUsers.DataSource = result;
        }

        private void dgvUsers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvUsers.SelectedRows[0].Cells[0].Value;
            frmUserDetails frm = new frmUserDetails(int.Parse(id.ToString()));
            frm.Show();
        }
    }   
}
