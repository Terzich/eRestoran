namespace eRestoran.WinUI.Restaurant
{
    partial class frmListOfReviews
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
            this.txtNumberOfReviews = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RestaurantReviewId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisitorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ukupan broj ostavljenih dojmova o restoranu od strance posjetilaca:";
            // 
            // txtNumberOfReviews
            // 
            this.txtNumberOfReviews.Location = new System.Drawing.Point(574, 69);
            this.txtNumberOfReviews.Name = "txtNumberOfReviews";
            this.txtNumberOfReviews.Size = new System.Drawing.Size(100, 22);
            this.txtNumberOfReviews.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RestaurantReviewId,
            this.UserId,
            this.VisitorName,
            this.Description,
            this.Grade});
            this.dataGridView1.Location = new System.Drawing.Point(1, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1233, 337);
            this.dataGridView1.TabIndex = 2;
            // 
            // RestaurantReviewId
            // 
            this.RestaurantReviewId.DataPropertyName = "RestaurantReviewId";
            this.RestaurantReviewId.HeaderText = "Broj dojma";
            this.RestaurantReviewId.MinimumWidth = 6;
            this.RestaurantReviewId.Name = "RestaurantReviewId";
            this.RestaurantReviewId.Width = 125;
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
            this.VisitorName.DataPropertyName = "VisitorName";
            this.VisitorName.HeaderText = "Ime i prezime posjetioca";
            this.VisitorName.MinimumWidth = 6;
            this.VisitorName.Name = "VisitorName";
            this.VisitorName.Width = 344;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Opis dojma";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            // 
            // Grade
            // 
            this.Grade.DataPropertyName = "Grade";
            this.Grade.HeaderText = "Ocjena";
            this.Grade.MinimumWidth = 6;
            this.Grade.Name = "Grade";
            this.Grade.Width = 125;
            // 
            // frmListOfReviews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtNumberOfReviews);
            this.Controls.Add(this.label1);
            this.Name = "frmListOfReviews";
            this.Text = "frmListOfReviews";
            this.Load += new System.EventHandler(this.frmListOfReviews_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumberOfReviews;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RestaurantReviewId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisitorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
    }
}