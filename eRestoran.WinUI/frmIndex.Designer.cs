namespace eRestoran.WinUI
{
    partial class frmIndex
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.restoranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmjenaPodatakaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledPreporukaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledPosjetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledDojmovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meniRestoranaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNovoJeloPićeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledPonudeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.posjetiociToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledSvihPosjetiocaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upravljanjeNagradamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upravljanjePopustimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajPosjetiocaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.superPonudeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledSuperPonudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajSuperPonuduToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 532);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(843, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(49, 20);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restoranToolStripMenuItem,
            this.meniRestoranaToolStripMenuItem,
            this.posjetiociToolStripMenuItem,
            this.superPonudeToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(843, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // restoranToolStripMenuItem
            // 
            this.restoranToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izmjenaPodatakaToolStripMenuItem,
            this.pregledPreporukaToolStripMenuItem,
            this.pregledPosjetaToolStripMenuItem,
            this.pregledDojmovaToolStripMenuItem});
            this.restoranToolStripMenuItem.Name = "restoranToolStripMenuItem";
            this.restoranToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.restoranToolStripMenuItem.Text = "Restoran";
            // 
            // izmjenaPodatakaToolStripMenuItem
            // 
            this.izmjenaPodatakaToolStripMenuItem.Name = "izmjenaPodatakaToolStripMenuItem";
            this.izmjenaPodatakaToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.izmjenaPodatakaToolStripMenuItem.Text = "Izmjena podataka";
            this.izmjenaPodatakaToolStripMenuItem.Click += new System.EventHandler(this.izmjenaPodatakaToolStripMenuItem_Click);
            // 
            // pregledPreporukaToolStripMenuItem
            // 
            this.pregledPreporukaToolStripMenuItem.Name = "pregledPreporukaToolStripMenuItem";
            this.pregledPreporukaToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.pregledPreporukaToolStripMenuItem.Text = "Pregled preporuka";
            this.pregledPreporukaToolStripMenuItem.Click += new System.EventHandler(this.pregledPreporukaToolStripMenuItem_Click);
            // 
            // pregledPosjetaToolStripMenuItem
            // 
            this.pregledPosjetaToolStripMenuItem.Name = "pregledPosjetaToolStripMenuItem";
            this.pregledPosjetaToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.pregledPosjetaToolStripMenuItem.Text = "Pregled posjeta";
            this.pregledPosjetaToolStripMenuItem.Click += new System.EventHandler(this.pregledPosjetaToolStripMenuItem_Click);
            // 
            // pregledDojmovaToolStripMenuItem
            // 
            this.pregledDojmovaToolStripMenuItem.Name = "pregledDojmovaToolStripMenuItem";
            this.pregledDojmovaToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.pregledDojmovaToolStripMenuItem.Text = "Pregled dojmova";
            this.pregledDojmovaToolStripMenuItem.Click += new System.EventHandler(this.pregledDojmovaToolStripMenuItem_Click);
            // 
            // meniRestoranaToolStripMenuItem
            // 
            this.meniRestoranaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajNovoJeloPićeToolStripMenuItem,
            this.pregledPonudeToolStripMenuItem});
            this.meniRestoranaToolStripMenuItem.Name = "meniRestoranaToolStripMenuItem";
            this.meniRestoranaToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.meniRestoranaToolStripMenuItem.Text = "Meni restorana";
            // 
            // dodajNovoJeloPićeToolStripMenuItem
            // 
            this.dodajNovoJeloPićeToolStripMenuItem.Name = "dodajNovoJeloPićeToolStripMenuItem";
            this.dodajNovoJeloPićeToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.dodajNovoJeloPićeToolStripMenuItem.Text = "Dodaj novo jelo / piće";
            this.dodajNovoJeloPićeToolStripMenuItem.Click += new System.EventHandler(this.dodajNovoJeloPićeToolStripMenuItem_Click);
            // 
            // pregledPonudeToolStripMenuItem
            // 
            this.pregledPonudeToolStripMenuItem.Name = "pregledPonudeToolStripMenuItem";
            this.pregledPonudeToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.pregledPonudeToolStripMenuItem.Text = "Pregled ponude";
            this.pregledPonudeToolStripMenuItem.Click += new System.EventHandler(this.pregledPonudeToolStripMenuItem_Click);
            // 
            // posjetiociToolStripMenuItem
            // 
            this.posjetiociToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledSvihPosjetiocaToolStripMenuItem,
            this.upravljanjeNagradamaToolStripMenuItem,
            this.upravljanjePopustimaToolStripMenuItem,
            this.dodajPosjetiocaToolStripMenuItem});
            this.posjetiociToolStripMenuItem.Name = "posjetiociToolStripMenuItem";
            this.posjetiociToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.posjetiociToolStripMenuItem.Text = "Posjetioci";
            // 
            // pregledSvihPosjetiocaToolStripMenuItem
            // 
            this.pregledSvihPosjetiocaToolStripMenuItem.Name = "pregledSvihPosjetiocaToolStripMenuItem";
            this.pregledSvihPosjetiocaToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.pregledSvihPosjetiocaToolStripMenuItem.Text = "Pregled svih posjetioca";
            this.pregledSvihPosjetiocaToolStripMenuItem.Click += new System.EventHandler(this.pregledSvihPosjetiocaToolStripMenuItem_Click);
            // 
            // upravljanjeNagradamaToolStripMenuItem
            // 
            this.upravljanjeNagradamaToolStripMenuItem.Name = "upravljanjeNagradamaToolStripMenuItem";
            this.upravljanjeNagradamaToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.upravljanjeNagradamaToolStripMenuItem.Text = "Upravljanje nagradama";
            this.upravljanjeNagradamaToolStripMenuItem.Click += new System.EventHandler(this.upravljanjeNagradamaToolStripMenuItem_Click);
            // 
            // upravljanjePopustimaToolStripMenuItem
            // 
            this.upravljanjePopustimaToolStripMenuItem.Name = "upravljanjePopustimaToolStripMenuItem";
            this.upravljanjePopustimaToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.upravljanjePopustimaToolStripMenuItem.Text = "Upravljanje popustima";
            this.upravljanjePopustimaToolStripMenuItem.Click += new System.EventHandler(this.upravljanjePopustimaToolStripMenuItem_Click);
            // 
            // dodajPosjetiocaToolStripMenuItem
            // 
            this.dodajPosjetiocaToolStripMenuItem.Name = "dodajPosjetiocaToolStripMenuItem";
            this.dodajPosjetiocaToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.dodajPosjetiocaToolStripMenuItem.Text = "Dodaj posjetioca";
            this.dodajPosjetiocaToolStripMenuItem.Click += new System.EventHandler(this.dodajPosjetiocaToolStripMenuItem_Click);
            // 
            // superPonudeToolStripMenuItem
            // 
            this.superPonudeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledSuperPonudaToolStripMenuItem,
            this.dodajSuperPonuduToolStripMenuItem});
            this.superPonudeToolStripMenuItem.Name = "superPonudeToolStripMenuItem";
            this.superPonudeToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.superPonudeToolStripMenuItem.Text = "Super ponude";
            // 
            // pregledSuperPonudaToolStripMenuItem
            // 
            this.pregledSuperPonudaToolStripMenuItem.Name = "pregledSuperPonudaToolStripMenuItem";
            this.pregledSuperPonudaToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.pregledSuperPonudaToolStripMenuItem.Text = "Pregled super ponuda";
            this.pregledSuperPonudaToolStripMenuItem.Click += new System.EventHandler(this.pregledSuperPonudaToolStripMenuItem_Click);
            // 
            // dodajSuperPonuduToolStripMenuItem
            // 
            this.dodajSuperPonuduToolStripMenuItem.Name = "dodajSuperPonuduToolStripMenuItem";
            this.dodajSuperPonuduToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.dodajSuperPonuduToolStripMenuItem.Text = "Dodaj super ponudu";
            this.dodajSuperPonuduToolStripMenuItem.Click += new System.EventHandler(this.dodajSuperPonuduToolStripMenuItem_Click);
            // 
            // frmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 558);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmIndex";
            this.Text = "frmIndex";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem posjetiociToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledSvihPosjetiocaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meniRestoranaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNovoJeloPićeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledPonudeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem superPonudeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledSuperPonudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajSuperPonuduToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upravljanjeNagradamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upravljanjePopustimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajPosjetiocaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoranToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmjenaPodatakaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledPreporukaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledPosjetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledDojmovaToolStripMenuItem;
    }
}



