namespace eRestoran.WinUI.Restaurant
{
    partial class frmListOfRecommendation
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
            this.dgvRecommendations = new System.Windows.Forms.DataGridView();
            this.VisitorRecommendationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisitorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecommendationDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecommendations)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broj ostavljenih preporuka od strane posjetilaca: ";
            // 
            // txtNumberOfVisits
            // 
            this.txtNumberOfVisits.Location = new System.Drawing.Point(472, 78);
            this.txtNumberOfVisits.Name = "txtNumberOfVisits";
            this.txtNumberOfVisits.ReadOnly = true;
            this.txtNumberOfVisits.Size = new System.Drawing.Size(100, 22);
            this.txtNumberOfVisits.TabIndex = 1;
            // 
            // dgvRecommendations
            // 
            this.dgvRecommendations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecommendations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VisitorRecommendationId,
            this.VisitorName,
            this.RecommendationDescription,
            this.UserID});
            this.dgvRecommendations.Location = new System.Drawing.Point(0, 130);
            this.dgvRecommendations.Name = "dgvRecommendations";
            this.dgvRecommendations.RowHeadersWidth = 51;
            this.dgvRecommendations.RowTemplate.Height = 24;
            this.dgvRecommendations.Size = new System.Drawing.Size(946, 321);
            this.dgvRecommendations.TabIndex = 2;
            // 
            // VisitorRecommendationId
            // 
            this.VisitorRecommendationId.DataPropertyName = "VisitorRecommendationId";
            this.VisitorRecommendationId.HeaderText = "Broj preporuke";
            this.VisitorRecommendationId.MinimumWidth = 6;
            this.VisitorRecommendationId.Name = "VisitorRecommendationId";
            this.VisitorRecommendationId.Width = 125;
            // 
            // VisitorName
            // 
            this.VisitorName.DataPropertyName = "VisitorName";
            this.VisitorName.HeaderText = "Ime i prezime posjetioca";
            this.VisitorName.MinimumWidth = 6;
            this.VisitorName.Name = "VisitorName";
            this.VisitorName.Width = 125;
            // 
            // RecommendationDescription
            // 
            this.RecommendationDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RecommendationDescription.DataPropertyName = "RecommendationDescription";
            this.RecommendationDescription.HeaderText = "Tekst preporuke";
            this.RecommendationDescription.MinimumWidth = 6;
            this.RecommendationDescription.Name = "RecommendationDescription";
            // 
            // UserID
            // 
            this.UserID.DataPropertyName = "UserId";
            this.UserID.HeaderText = "UserID";
            this.UserID.MinimumWidth = 6;
            this.UserID.Name = "UserID";
            this.UserID.Visible = false;
            this.UserID.Width = 125;
            // 
            // frmListOfRecommendation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 450);
            this.Controls.Add(this.dgvRecommendations);
            this.Controls.Add(this.txtNumberOfVisits);
            this.Controls.Add(this.label1);
            this.Name = "frmListOfRecommendation";
            this.Text = "frmListOfRecommendation";
            this.Load += new System.EventHandler(this.frmListOfRecommendation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecommendations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumberOfVisits;
        private System.Windows.Forms.DataGridView dgvRecommendations;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisitorRecommendationId;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisitorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecommendationDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
    }
}