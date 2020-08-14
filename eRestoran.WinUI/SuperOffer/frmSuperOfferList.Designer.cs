namespace eRestoran.WinUI.SuperOffer
{
    partial class frmSuperOfferList
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
            this.dgvOffers = new System.Windows.Forms.DataGridView();
            this.SuperOfferId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OfferStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OfferEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOffers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOffers
            // 
            this.dgvOffers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOffers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SuperOfferId,
            this.Description,
            this.OfferStart,
            this.OfferEnd,
            this.Discount});
            this.dgvOffers.Location = new System.Drawing.Point(1, 57);
            this.dgvOffers.Name = "dgvOffers";
            this.dgvOffers.RowHeadersWidth = 51;
            this.dgvOffers.RowTemplate.Height = 24;
            this.dgvOffers.Size = new System.Drawing.Size(801, 392);
            this.dgvOffers.TabIndex = 0;
            // 
            // SuperOfferId
            // 
            this.SuperOfferId.DataPropertyName = "SuperOfferId";
            this.SuperOfferId.HeaderText = "Id";
            this.SuperOfferId.MinimumWidth = 6;
            this.SuperOfferId.Name = "SuperOfferId";
            this.SuperOfferId.Width = 125;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Opis ponude";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.Width = 125;
            // 
            // OfferStart
            // 
            this.OfferStart.DataPropertyName = "OfferStart";
            this.OfferStart.HeaderText = "Početak super ponude";
            this.OfferStart.MinimumWidth = 6;
            this.OfferStart.Name = "OfferStart";
            this.OfferStart.Width = 125;
            // 
            // OfferEnd
            // 
            this.OfferEnd.DataPropertyName = "OfferEnd";
            this.OfferEnd.HeaderText = "Kraj super ponude";
            this.OfferEnd.MinimumWidth = 6;
            this.OfferEnd.Name = "OfferEnd";
            this.OfferEnd.Width = 125;
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "DiscountValue";
            this.Discount.HeaderText = "Iznos popusta";
            this.Discount.MinimumWidth = 6;
            this.Discount.Name = "Discount";
            this.Discount.Width = 125;
            // 
            // frmSuperOfferList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvOffers);
            this.Name = "frmSuperOfferList";
            this.Text = "frmSuperOfferList";
            this.Load += new System.EventHandler(this.frmSuperOfferList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOffers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOffers;
        private System.Windows.Forms.DataGridViewTextBoxColumn SuperOfferId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn OfferStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn OfferEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
    }
}