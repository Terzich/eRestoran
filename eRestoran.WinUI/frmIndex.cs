﻿using eRestoran.WinUI.Award;
using eRestoran.WinUI.Key;
using eRestoran.WinUI.Restaurant;
using eRestoran.WinUI.SuperOffer;
using eRestoran.WinUI.Users;
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
    public partial class frmIndex : Form
    {
        private int childFormNumber = 0;

        public frmIndex()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        //    statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void pregledSvihPosjetiocaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListOfUsers louForm = new frmListOfUsers();
            louForm.Show();

        }

        private void noviPosjetiocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserDetails frm = new frmUserDetails();
            frm.Show();
        }

        private void urediToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRestaurantDetails frm = new frmRestaurantDetails();
            frm.Show();
        }

        private void dodajNovoJeloPićeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddRestaurantMenu_Item frm = new frmAddRestaurantMenu_Item();
            frm.Show();

        }

        private void dodajSuperPonuduToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSuperOffer frm = new AddSuperOffer();
            frm.Show();
        }

        private void pregledSuperPonudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSuperOfferList frm = new frmSuperOfferList();
            frm.Show();
        }

        private void dodijeliNagraduPosjetiocuToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void upravljanjeNagradamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAwardManagment frm = new frmAwardManagment();
            frm.Show();
        }

        private void upravljanjePopustimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDiscountManagment frm = new frmDiscountManagment();
            frm.Show();
        }

        private void dodajPosjetiocaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserDetails frm = new frmUserDetails();
            frm.Show();
        }

        private void izmjenaPodatakaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRestaurantDetails frm = new frmRestaurantDetails();
            frm.Show();
        }

        private void pregledPreporukaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListOfRecommendation frm = new frmListOfRecommendation();
            frm.Show();
        }

        private void pregledPosjetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListOfVisits frm = new frmListOfVisits();
            frm.Show();
        }

        private void pregledDojmovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListOfReviews frm = new frmListOfReviews();
            frm.Show();


        }

        private void pregledPonudeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowRestaurantMenuItems frm = new frmShowRestaurantMenuItems();
            frm.Show();
        }

        private void listaAktivnihKljučevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListOfKeys frm = new frmListOfKeys();
            frm.Show();
        }
    }
}
