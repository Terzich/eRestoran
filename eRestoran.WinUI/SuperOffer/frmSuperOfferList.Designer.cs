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
            this.OfferStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OfferEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RestaurantMenuItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountTypeText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Deactivate = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOffers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOffers
            // 
            this.dgvOffers.AllowUserToAddRows = false;
            this.dgvOffers.AllowUserToDeleteRows = false;
            this.dgvOffers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOffers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SuperOfferId,
            this.OfferStart,
            this.OfferEnd,
            this.ItemCategoryId,
            this.Description,
            this.ItemTypeId,
            this.RestaurantMenuItemId,
            this.DiscountType,
            this.DiscountTypeText,
            this.DiscountValue,
            this.Active,
            this.Deactivate});
            this.dgvOffers.Location = new System.Drawing.Point(2, 39);
            this.dgvOffers.Name = "dgvOffers";
            this.dgvOffers.ReadOnly = true;
            this.dgvOffers.RowHeadersWidth = 51;
            this.dgvOffers.RowTemplate.Height = 24;
            this.dgvOffers.Size = new System.Drawing.Size(1404, 404);
            this.dgvOffers.TabIndex = 0;
            this.dgvOffers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOffers_CellContentClick);
            // 
            // SuperOfferId
            // 
            this.SuperOfferId.DataPropertyName = "SuperOfferId";
            this.SuperOfferId.HeaderText = "Redni broj";
            this.SuperOfferId.MinimumWidth = 6;
            this.SuperOfferId.Name = "SuperOfferId";
            this.SuperOfferId.ReadOnly = true;
            this.SuperOfferId.Width = 125;
            // 
            // OfferStart
            // 
            this.OfferStart.DataPropertyName = "OfferStart";
            this.OfferStart.HeaderText = "Početak super ponude:";
            this.OfferStart.MinimumWidth = 6;
            this.OfferStart.Name = "OfferStart";
            this.OfferStart.ReadOnly = true;
            this.OfferStart.Width = 125;
            // 
            // OfferEnd
            // 
            this.OfferEnd.DataPropertyName = "OfferEnd";
            this.OfferEnd.HeaderText = "Kraj super ponude:";
            this.OfferEnd.MinimumWidth = 6;
            this.OfferEnd.Name = "OfferEnd";
            this.OfferEnd.ReadOnly = true;
            this.OfferEnd.Width = 125;
            // 
            // ItemCategoryId
            // 
            this.ItemCategoryId.DataPropertyName = "ItemCategoryId";
            this.ItemCategoryId.HeaderText = "ItemCategoryId";
            this.ItemCategoryId.MinimumWidth = 6;
            this.ItemCategoryId.Name = "ItemCategoryId";
            this.ItemCategoryId.ReadOnly = true;
            this.ItemCategoryId.Visible = false;
            this.ItemCategoryId.Width = 125;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Opis";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // ItemTypeId
            // 
            this.ItemTypeId.DataPropertyName = "ItemTypeId";
            this.ItemTypeId.HeaderText = "IT";
            this.ItemTypeId.MinimumWidth = 6;
            this.ItemTypeId.Name = "ItemTypeId";
            this.ItemTypeId.ReadOnly = true;
            this.ItemTypeId.Visible = false;
            this.ItemTypeId.Width = 125;
            // 
            // RestaurantMenuItemId
            // 
            this.RestaurantMenuItemId.DataPropertyName = "RestaurantMenuItemId";
            this.RestaurantMenuItemId.HeaderText = "RMI";
            this.RestaurantMenuItemId.MinimumWidth = 6;
            this.RestaurantMenuItemId.Name = "RestaurantMenuItemId";
            this.RestaurantMenuItemId.ReadOnly = true;
            this.RestaurantMenuItemId.Visible = false;
            this.RestaurantMenuItemId.Width = 125;
            // 
            // DiscountType
            // 
            this.DiscountType.DataPropertyName = "DiscountType";
            this.DiscountType.HeaderText = "DT";
            this.DiscountType.MinimumWidth = 6;
            this.DiscountType.Name = "DiscountType";
            this.DiscountType.ReadOnly = true;
            this.DiscountType.Visible = false;
            this.DiscountType.Width = 125;
            // 
            // DiscountTypeText
            // 
            this.DiscountTypeText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiscountTypeText.DataPropertyName = "DiscountTypeText";
            this.DiscountTypeText.HeaderText = "Opis popusta";
            this.DiscountTypeText.MinimumWidth = 6;
            this.DiscountTypeText.Name = "DiscountTypeText";
            this.DiscountTypeText.ReadOnly = true;
            // 
            // DiscountValue
            // 
            this.DiscountValue.DataPropertyName = "DiscountValue";
            this.DiscountValue.HeaderText = "Iznos popusta";
            this.DiscountValue.MinimumWidth = 6;
            this.DiscountValue.Name = "DiscountValue";
            this.DiscountValue.ReadOnly = true;
            this.DiscountValue.Width = 125;
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
            this.Deactivate.HeaderText = "Akcija";
            this.Deactivate.MinimumWidth = 6;
            this.Deactivate.Name = "Deactivate";
            this.Deactivate.ReadOnly = true;
            this.Deactivate.Text = "Deaktiviraj";
            this.Deactivate.UseColumnTextForButtonValue = true;
            this.Deactivate.Width = 125;
            // 
            // frmSuperOfferList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 445);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn OfferStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn OfferEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RestaurantMenuItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountType;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountTypeText;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountValue;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Active;
        private System.Windows.Forms.DataGridViewButtonColumn Deactivate;
    }
}