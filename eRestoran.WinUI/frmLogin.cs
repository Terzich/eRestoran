using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eRestoran.WinUI
{
    public partial class frmLogin : Form
    {
        APIService _serviceC = new APIService("ItemCategory");

        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                APIService._Username = txtUsername.Text;
                APIService._Password= txtPassword.Text;
                await _serviceC.Get<dynamic>(null);
                frmIndex frm = new frmIndex();
                frm.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Autentifikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
