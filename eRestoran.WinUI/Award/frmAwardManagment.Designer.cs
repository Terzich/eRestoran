namespace eRestoran.WinUI.Award
{
    partial class frmAwardManagment
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
            this.dgvAwardList = new System.Windows.Forms.DataGridView();
            this.AwardId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisitorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AwardDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Deactivate = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAwardList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAwardList
            // 
            this.dgvAwardList.AllowUserToAddRows = false;
            this.dgvAwardList.AllowUserToDeleteRows = false;
            this.dgvAwardList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAwardList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AwardId,
            this.UserId,
            this.VisitorName,
            this.Description,
            this.AwardDate,
            this.Active,
            this.Deactivate});
            this.dgvAwardList.Location = new System.Drawing.Point(0, 117);
            this.dgvAwardList.Name = "dgvAwardList";
            this.dgvAwardList.ReadOnly = true;
            this.dgvAwardList.RowHeadersWidth = 51;
            this.dgvAwardList.RowTemplate.Height = 24;
            this.dgvAwardList.Size = new System.Drawing.Size(959, 371);
            this.dgvAwardList.TabIndex = 0;
            this.dgvAwardList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAwardList_CellContentClick);
            // 
            // AwardId
            // 
            this.AwardId.DataPropertyName = "AwardId";
            this.AwardId.HeaderText = "AwardId";
            this.AwardId.MinimumWidth = 6;
            this.AwardId.Name = "AwardId";
            this.AwardId.ReadOnly = true;
            this.AwardId.Width = 128;
            // 
            // UserId
            // 
            this.UserId.DataPropertyName = "UserId";
            this.UserId.HeaderText = "UserId";
            this.UserId.MinimumWidth = 6;
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            this.UserId.Visible = false;
            this.UserId.Width = 125;
            // 
            // VisitorName
            // 
            this.VisitorName.DataPropertyName = "VisitorName";
            this.VisitorName.HeaderText = "Ime i prezime posjetioca";
            this.VisitorName.MinimumWidth = 6;
            this.VisitorName.Name = "VisitorName";
            this.VisitorName.ReadOnly = true;
            this.VisitorName.Width = 125;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Opis nagrade";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 125;
            // 
            // AwardDate
            // 
            this.AwardDate.DataPropertyName = "AwardDate";
            this.AwardDate.HeaderText = "Datum dodavanja nagrade";
            this.AwardDate.MinimumWidth = 20;
            this.AwardDate.Name = "AwardDate";
            this.AwardDate.ReadOnly = true;
            this.AwardDate.Width = 187;
            // 
            // Active
            // 
            this.Active.DataPropertyName = "Active";
            this.Active.HeaderText = "Aktivna";
            this.Active.MinimumWidth = 6;
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            this.Active.Width = 125;
            // 
            // Deactivate
            // 
            this.Deactivate.DataPropertyName = "Deactivate";
            this.Deactivate.HeaderText = "Deaktiviraj nagradu";
            this.Deactivate.MinimumWidth = 6;
            this.Deactivate.Name = "Deactivate";
            this.Deactivate.ReadOnly = true;
            this.Deactivate.UseColumnTextForButtonValue = true;
            this.Deactivate.Width = 125;
            // 
            // frmAwardManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 482);
            this.Controls.Add(this.dgvAwardList);
            this.Name = "frmAwardManagment";
            this.Text = "frmAwardManagment";
            this.Load += new System.EventHandler(this.frmAwardManagment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAwardList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAwardList;
        private System.Windows.Forms.DataGridViewTextBoxColumn AwardId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisitorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn AwardDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Active;
        private System.Windows.Forms.DataGridViewButtonColumn Deactivate;
    }
}