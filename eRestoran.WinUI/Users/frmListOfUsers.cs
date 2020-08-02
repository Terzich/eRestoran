using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            var result= await _apiService.Get<List<Model.User>>();
            dgvUsers.DataSource = result;
        }
    }   
}
