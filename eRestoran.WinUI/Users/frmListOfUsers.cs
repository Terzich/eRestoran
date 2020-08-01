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
        public frmListOfUsers()
        {
            InitializeComponent();
        }

        private void btnShowUsers_Click(object sender, EventArgs e)
        {
            var result = "https://localhost:44375/api/User".GetJsonAsync<List<Model.User>>().Result;
            dgvUsers.DataSource = result;
        }
    }
}
