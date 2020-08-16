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
    public partial class frmAddAward : Form
    {
        private int? _id = null;
        private readonly APIService _apiServiceUser = new APIService("User");
        private readonly APIService _apiServiceAward = new APIService("Award");



        public frmAddAward(int? userId = null)
        {
            InitializeComponent();
            _id = userId;
        }

        private async void frmAddAward_Load(object sender, EventArgs e)
        {
            var user = await _apiServiceUser.GetById<Model.User>(_id);
            var visitorName = user.Name + user.Surname;
            txtVisitorName.Text = visitorName;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            AwardUpsertRequest req = new AwardUpsertRequest
            {
                UserId=_id.Value,
                Description=txtAwardDescription.Text,
                AwardDate=DateTime.Now,
                Active=true
            };
            Model.Award r = null;
            r=await _apiServiceAward.Insert<Model.Award>(req);
            if (r != null)
                MessageBox.Show("Nagrada uspješno dodana!", "Nagrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
