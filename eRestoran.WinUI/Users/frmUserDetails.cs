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

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var objU = new UserInsertRequest
                {
                    Name = txtName.Text,
                    Surname = txtSurname.Text,
                    DateOfBirth = dtpDateOfBirth.Value,
                    Address = txtAddress.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    Password = txtPass.Text,
                    ConfirmationPassword = txtPassC.Text,
                    Username = txtUsername.Text
                };
                Model.User entity = null;
                if (_id.HasValue)
                {
                    entity=await _service.Update<Model.User>(_id.Value, objU);
                    MessageBox.Show("Podaci korisnika uspješno promjenjeni!");
                }
                else
                {
                    entity=await _service.Insert<Model.User>(objU);
                    MessageBox.Show("Novi korisnik uspješno dodan!");
                }
            }
            
            
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
                dtpDateOfBirth.Value = user.DateOfBirth;

            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider.SetError(txtName, Properties.Resources.Validation_Field_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtName, null);

            }
        }
        private void txtSurname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSurname.Text))
            {
                errorProvider.SetError(txtSurname, Properties.Resources.Validation_Field_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtSurname, null);

            }
        }
        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                errorProvider.SetError(txtAddress, Properties.Resources.Validation_Field_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtAddress, null);

            }
        }
        private void txtPhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                errorProvider.SetError(txtPhoneNumber, Properties.Resources.Validation_Field_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPhoneNumber, null);

            }
        }

    }
}
