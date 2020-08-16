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
            this.components = new System.ComponentModel.Container();
            this.dgvAwardList = new System.Windows.Forms.DataGridView();
            this.awardIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.awardDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Deactivate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.awardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAwardList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.awardBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAwardList
            // 
            this.dgvAwardList.AllowUserToAddRows = false;
            this.dgvAwardList.AllowUserToDeleteRows = false;
            this.dgvAwardList.AutoGenerateColumns = false;
            this.dgvAwardList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAwardList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.awardIdDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.visitorNameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.awardDateDataGridViewTextBoxColumn,
            this.activeDataGridViewTextBoxColumn,
            this.Deactivate});
            this.dgvAwardList.DataSource = this.awardBindingSource;
            this.dgvAwardList.Location = new System.Drawing.Point(1, 4);
            this.dgvAwardList.Name = "dgvAwardList";
            this.dgvAwardList.ReadOnly = true;
            this.dgvAwardList.RowHeadersWidth = 51;
            this.dgvAwardList.RowTemplate.Height = 24;
            this.dgvAwardList.Size = new System.Drawing.Size(999, 447);
            this.dgvAwardList.TabIndex = 0;
            this.dgvAwardList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAwardList_CellContentClick);
            // 
            // awardIdDataGridViewTextBoxColumn
            // 
            this.awardIdDataGridViewTextBoxColumn.DataPropertyName = "AwardId";
            this.awardIdDataGridViewTextBoxColumn.HeaderText = "AwardId";
            this.awardIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.awardIdDataGridViewTextBoxColumn.Name = "awardIdDataGridViewTextBoxColumn";
            this.awardIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.awardIdDataGridViewTextBoxColumn.Visible = false;
            this.awardIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIdDataGridViewTextBoxColumn.Visible = false;
            this.userIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // visitorNameDataGridViewTextBoxColumn
            // 
            this.visitorNameDataGridViewTextBoxColumn.DataPropertyName = "VisitorName";
            this.visitorNameDataGridViewTextBoxColumn.HeaderText = "Ime i prezime posjetioca";
            this.visitorNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.visitorNameDataGridViewTextBoxColumn.Name = "visitorNameDataGridViewTextBoxColumn";
            this.visitorNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.visitorNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Opis nagrade";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // awardDateDataGridViewTextBoxColumn
            // 
            this.awardDateDataGridViewTextBoxColumn.DataPropertyName = "AwardDate";
            this.awardDateDataGridViewTextBoxColumn.HeaderText = "Datum dodavanja nagrade";
            this.awardDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.awardDateDataGridViewTextBoxColumn.Name = "awardDateDataGridViewTextBoxColumn";
            this.awardDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.awardDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // activeDataGridViewTextBoxColumn
            // 
            this.activeDataGridViewTextBoxColumn.DataPropertyName = "Active";
            this.activeDataGridViewTextBoxColumn.HeaderText = "Aktivna";
            this.activeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.activeDataGridViewTextBoxColumn.Name = "activeDataGridViewTextBoxColumn";
            this.activeDataGridViewTextBoxColumn.ReadOnly = true;
            this.activeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.activeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.activeDataGridViewTextBoxColumn.Width = 125;
            // 
            // Deactivate
            // 
            this.Deactivate.DataPropertyName = "AwardId";
            this.Deactivate.HeaderText = "Deaktiviraj nagradu";
            this.Deactivate.MinimumWidth = 6;
            this.Deactivate.Name = "Deactivate";
            this.Deactivate.ReadOnly = true;
            this.Deactivate.Text = "Deaktiviraj nagradu";
            this.Deactivate.UseColumnTextForButtonValue = true;
            this.Deactivate.Width = 125;
            // 
            // awardBindingSource
            // 
            this.awardBindingSource.DataSource = typeof(eRestoran.Model.Award);
            // 
            // frmAwardManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.dgvAwardList);
            this.Name = "frmAwardManagment";
            this.Text = "frmAwardManagment";
            this.Load += new System.EventHandler(this.frmAwardManagment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAwardList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.awardBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAwardList;
        private System.Windows.Forms.BindingSource awardBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn awardIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn awardDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Deactivate;
    }
}