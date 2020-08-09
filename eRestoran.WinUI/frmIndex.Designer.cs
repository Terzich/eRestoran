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
            this.izmjenaPodatakaRestoranaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urediToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.posjetiociToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledSvihPosjetiocaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviPosjetiocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meniRestoranaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNovoJeloPićeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledPonudeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.izmjenaPodatakaRestoranaToolStripMenuItem,
            this.meniRestoranaToolStripMenuItem,
            this.posjetiociToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(843, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // izmjenaPodatakaRestoranaToolStripMenuItem
            // 
            this.izmjenaPodatakaRestoranaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.urediToolStripMenuItem});
            this.izmjenaPodatakaRestoranaToolStripMenuItem.Name = "izmjenaPodatakaRestoranaToolStripMenuItem";
            this.izmjenaPodatakaRestoranaToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.izmjenaPodatakaRestoranaToolStripMenuItem.Text = "Izmjena podataka restorana";
            // 
            // urediToolStripMenuItem
            // 
            this.urediToolStripMenuItem.Name = "urediToolStripMenuItem";
            this.urediToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.urediToolStripMenuItem.Text = "Uredi";
            this.urediToolStripMenuItem.Click += new System.EventHandler(this.urediToolStripMenuItem_Click);
            // 
            // posjetiociToolStripMenuItem
            // 
            this.posjetiociToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledSvihPosjetiocaToolStripMenuItem,
            this.noviPosjetiocToolStripMenuItem});
            this.posjetiociToolStripMenuItem.Name = "posjetiociToolStripMenuItem";
            this.posjetiociToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.posjetiociToolStripMenuItem.Text = "Posjetioci";
            // 
            // pregledSvihPosjetiocaToolStripMenuItem
            // 
            this.pregledSvihPosjetiocaToolStripMenuItem.Name = "pregledSvihPosjetiocaToolStripMenuItem";
            this.pregledSvihPosjetiocaToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.pregledSvihPosjetiocaToolStripMenuItem.Text = "Pregled svih posjetioca";
            this.pregledSvihPosjetiocaToolStripMenuItem.Click += new System.EventHandler(this.pregledSvihPosjetiocaToolStripMenuItem_Click);
            // 
            // noviPosjetiocToolStripMenuItem
            // 
            this.noviPosjetiocToolStripMenuItem.Name = "noviPosjetiocToolStripMenuItem";
            this.noviPosjetiocToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.noviPosjetiocToolStripMenuItem.Text = "Novi posjetioc";
            this.noviPosjetiocToolStripMenuItem.Click += new System.EventHandler(this.noviPosjetiocToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem noviPosjetiocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmjenaPodatakaRestoranaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urediToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meniRestoranaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNovoJeloPićeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledPonudeToolStripMenuItem;
    }
}



