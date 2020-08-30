namespace eRestoran.WinUI.Users
{
    partial class frmListOfUsers
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.btnShowUsers = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfVisits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddAward = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AddDiscount = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvUsers);
            this.groupBox1.Location = new System.Drawing.Point(21, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 375);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Posjetioci";
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.Ime,
            this.Prezime,
            this.DateOfBirth,
            this.Adresa,
            this.NumberOfVisits,
            this.AddAward,
            this.AddDiscount});
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.Location = new System.Drawing.Point(3, 18);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(749, 354);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentClick);
            // 
            // btnShowUsers
            // 
            this.btnShowUsers.Location = new System.Drawing.Point(611, 25);
            this.btnShowUsers.Name = "btnShowUsers";
            this.btnShowUsers.Size = new System.Drawing.Size(136, 41);
            this.btnShowUsers.TabIndex = 1;
            this.btnShowUsers.Text = "Prikaži posjetioce";
            this.btnShowUsers.UseVisualStyleBackColor = true;
            this.btnShowUsers.Click += new System.EventHandler(this.btnShowUsers_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(244, 35);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(294, 22);
            this.searchBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pretraga po imenu:";
            // 
            // UserID
            // 
            this.UserID.DataPropertyName = "UserID";
            this.UserID.HeaderText = "UserID";
            this.UserID.MinimumWidth = 6;
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            this.UserID.Visible = false;
            this.UserID.Width = 125;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Name";
            this.Ime.HeaderText = "Ime";
            this.Ime.MinimumWidth = 6;
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            this.Ime.Width = 125;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Surname";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.MinimumWidth = 6;
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            this.Prezime.Width = 125;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.DataPropertyName = "DateOfBirth";
            this.DateOfBirth.HeaderText = "Datum rođenja";
            this.DateOfBirth.MinimumWidth = 6;
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.ReadOnly = true;
            this.DateOfBirth.Width = 125;
            // 
            // Adresa
            // 
            this.Adresa.DataPropertyName = "Address";
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.MinimumWidth = 6;
            this.Adresa.Name = "Adresa";
            this.Adresa.ReadOnly = true;
            this.Adresa.Width = 125;
            // 
            // NumberOfVisits
            // 
            this.NumberOfVisits.DataPropertyName = "NumberOfVisits";
            this.NumberOfVisits.HeaderText = "Broj posjeta";
            this.NumberOfVisits.MinimumWidth = 6;
            this.NumberOfVisits.Name = "NumberOfVisits";
            this.NumberOfVisits.ReadOnly = true;
            this.NumberOfVisits.Width = 125;
            // 
            // AddAward
            // 
            this.AddAward.DataPropertyName = "AddAward";
            this.AddAward.HeaderText = "Dodijeli nagradu";
            this.AddAward.MinimumWidth = 6;
            this.AddAward.Name = "AddAward";
            this.AddAward.ReadOnly = true;
            this.AddAward.Text = "Dodijeli nagradu";
            this.AddAward.ToolTipText = "Dodijeli nagradu";
            this.AddAward.UseColumnTextForButtonValue = true;
            this.AddAward.Width = 125;
            // 
            // AddDiscount
            // 
            this.AddDiscount.DataPropertyName = "AddDiscount";
            this.AddDiscount.HeaderText = "Dodijeli popust";
            this.AddDiscount.MinimumWidth = 6;
            this.AddDiscount.Name = "AddDiscount";
            this.AddDiscount.ReadOnly = true;
            this.AddDiscount.Text = "Dodijeli popust";
            this.AddDiscount.UseColumnTextForButtonValue = true;
            this.AddDiscount.Width = 125;
            // 
            // frmListOfUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.btnShowUsers);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmListOfUsers";
            this.Text = "frmListOfUsers";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btnShowUsers;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfVisits;
        private System.Windows.Forms.DataGridViewButtonColumn AddAward;
        private System.Windows.Forms.DataGridViewButtonColumn AddDiscount;
    }
}