namespace eRestoran.WinUI.Restaurant
{
    partial class frmListOfVisits
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumberOfVisits = new System.Windows.Forms.TextBox();
            this.dgvVisits = new System.Windows.Forms.DataGridView();
            this.VisitId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisitorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfVisit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisits)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ukupan broj ostavljenih posjeta od strane posjetilaca:";
            // 
            // txtNumberOfVisits
            // 
            this.txtNumberOfVisits.Location = new System.Drawing.Point(218, 109);
            this.txtNumberOfVisits.Name = "txtNumberOfVisits";
            this.txtNumberOfVisits.Size = new System.Drawing.Size(100, 22);
            this.txtNumberOfVisits.TabIndex = 1;
            // 
            // dgvVisits
            // 
            this.dgvVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VisitId,
            this.UserId,
            this.VisitorName,
            this.DateOfVisit});
            this.dgvVisits.Location = new System.Drawing.Point(2, 151);
            this.dgvVisits.Name = "dgvVisits";
            this.dgvVisits.RowHeadersWidth = 51;
            this.dgvVisits.RowTemplate.Height = 24;
            this.dgvVisits.Size = new System.Drawing.Size(525, 228);
            this.dgvVisits.TabIndex = 2;
            // 
            // VisitId
            // 
            this.VisitId.DataPropertyName = "VisitId";
            this.VisitId.HeaderText = "Broj posjete";
            this.VisitId.MinimumWidth = 6;
            this.VisitId.Name = "VisitId";
            this.VisitId.Width = 125;
            // 
            // UserId
            // 
            this.UserId.DataPropertyName = "UserId";
            this.UserId.HeaderText = "UserId";
            this.UserId.MinimumWidth = 6;
            this.UserId.Name = "UserId";
            this.UserId.Visible = false;
            this.UserId.Width = 125;
            // 
            // VisitorName
            // 
            this.VisitorName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VisitorName.DataPropertyName = "VisitorName";
            this.VisitorName.HeaderText = "Ime i prezime posjetioca";
            this.VisitorName.MinimumWidth = 6;
            this.VisitorName.Name = "VisitorName";
            // 
            // DateOfVisit
            // 
            this.DateOfVisit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateOfVisit.DataPropertyName = "DateOfVisit";
            this.DateOfVisit.HeaderText = "Datum posjete";
            this.DateOfVisit.MinimumWidth = 6;
            this.DateOfVisit.Name = "DateOfVisit";
            // 
            // frmListOfVisits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 380);
            this.Controls.Add(this.dgvVisits);
            this.Controls.Add(this.txtNumberOfVisits);
            this.Controls.Add(this.label1);
            this.Name = "frmListOfVisits";
            this.Text = "frmListOfVisits";
            this.Load += new System.EventHandler(this.frmListOfVisits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumberOfVisits;
        private System.Windows.Forms.DataGridView dgvVisits;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisitId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisitorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfVisit;
    }
}