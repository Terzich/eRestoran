using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eRestoran.WinUI.Users
{
    public partial class frmUserDetails : Form
    {

        private readonly APIService _service = new APIService("User");

        private int? _id = null;
        public frmUserDetails(int? userId=null)
        {
            InitializeComponent();
            _id = userId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private async void frmUserDetails_Load(object sender, EventArgs e)
        {
            if(_id.HasValue)
            {
                var user = await _service.GetById<Model.User>(_id);
                txtName.Text = user.Name;
                txtSurname.Text = user.Surname;
                txtAddress.Text = user.Address;
                txtPhoneNumber.Text = user.PhoneNumber;
               // dtpDateOfBirth.Value = user.DateOfBirth;

            }
        }
    }
}
