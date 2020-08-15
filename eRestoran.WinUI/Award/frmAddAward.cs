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

        public frmAddAward(int? userId = null)
        {
            InitializeComponent();
            _id = userId;
        }
    }
}
