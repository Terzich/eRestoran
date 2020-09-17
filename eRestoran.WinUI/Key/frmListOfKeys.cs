using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eRestoran.WinUI.Key
{
    public partial class frmListOfKeys : Form
    {
        private readonly APIService _serviceK = new APIService("Key");
        private readonly Random _random = new Random();

        public frmListOfKeys()
        {
            InitializeComponent();
        }

        private async void frmListOfKeys_Load(object sender, EventArgs e)
        {
            var rez = await _serviceK.Get<List<Model.Key>>(null);
            txtNumberOfKeys.Text = rez.Count.ToString();
            dataGridView1.DataSource = rez;

        }

        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            Model.Request.KeyUpsertRequest req = new Model.Request.KeyUpsertRequest { Active = true };
            for (int i = 0; i < 10; i++)
            {
                req.Key1 = _random.Next(100000000, 999999999);
                await _serviceK.Insert<Model.Key>(req);
            }
            MessageBox.Show("Uspješno generisano, novih 10 kodova", "Generisanje kodova", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmListOfKeys_Load(this, null);

        }
    }
}
