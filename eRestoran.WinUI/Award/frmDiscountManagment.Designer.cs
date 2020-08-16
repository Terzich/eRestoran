namespace eRestoran.WinUI.Award
{
    partial class frmDiscountManagment
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
            this.dgvD = new System.Windows.Forms.DataGridView();
            this.DiscountType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeactivateDiscount = new System.Windows.Forms.DataGridViewButtonColumn();
            this.discountIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemCategoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restaurantMenuItemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.discountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvD
            // 
            this.dgvD.AllowUserToAddRows = false;
            this.dgvD.AllowUserToDeleteRows = false;
            this.dgvD.AutoGenerateColumns = false;
            this.dgvD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.discountIdDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.discountTypeIdDataGridViewTextBoxColumn,
            this.itemTypeIdDataGridViewTextBoxColumn,
            this.itemCategoryIdDataGridViewTextBoxColumn,
            this.restaurantMenuItemIdDataGridViewTextBoxColumn,
            this.visitorNameDataGridViewTextBoxColumn,
            this.discountDateDataGridViewTextBoxColumn,
            this.DiscountType,
            this.discountValueDataGridViewTextBoxColumn,
            this.activeDataGridViewTextBoxColumn,
            this.DeactivateDiscount});
            this.dgvD.DataSource = this.discountBindingSource;
            this.dgvD.Location = new System.Drawing.Point(1, 5);
            this.dgvD.Name = "dgvD";
            this.dgvD.ReadOnly = true;
            this.dgvD.RowHeadersWidth = 51;
            this.dgvD.RowTemplate.Height = 24;
            this.dgvD.Size = new System.Drawing.Size(1042, 461);
            this.dgvD.TabIndex = 0;
            this.dgvD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvD_CellContentClick);
            // 
            // DiscountType
            // 
            this.DiscountType.DataPropertyName = "DiscountType";
            this.DiscountType.HeaderText = "Vrsta popusta";
            this.DiscountType.MinimumWidth = 6;
            this.DiscountType.Name = "DiscountType";
            this.DiscountType.ReadOnly = true;
            this.DiscountType.Width = 125;
            // 
            // DeactivateDiscount
            // 
            this.DeactivateDiscount.DataPropertyName = "DeactivateDiscount";
            this.DeactivateDiscount.HeaderText = "Isključi popust";
            this.DeactivateDiscount.MinimumWidth = 6;
            this.DeactivateDiscount.Name = "DeactivateDiscount";
            this.DeactivateDiscount.ReadOnly = true;
            this.DeactivateDiscount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeactivateDiscount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DeactivateDiscount.Text = "Deaktiviraj";
            this.DeactivateDiscount.UseColumnTextForButtonValue = true;
            this.DeactivateDiscount.Width = 125;
            // 
            // discountIdDataGridViewTextBoxColumn
            // 
            this.discountIdDataGridViewTextBoxColumn.DataPropertyName = "DiscountId";
            this.discountIdDataGridViewTextBoxColumn.HeaderText = "DiscountId";
            this.discountIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.discountIdDataGridViewTextBoxColumn.Name = "discountIdDataGridViewTextBoxColumn";
            this.discountIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.discountIdDataGridViewTextBoxColumn.Visible = false;
            this.discountIdDataGridViewTextBoxColumn.Width = 125;
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
            // discountTypeIdDataGridViewTextBoxColumn
            // 
            this.discountTypeIdDataGridViewTextBoxColumn.DataPropertyName = "DiscountTypeId";
            this.discountTypeIdDataGridViewTextBoxColumn.HeaderText = "DiscountTypeId";
            this.discountTypeIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.discountTypeIdDataGridViewTextBoxColumn.Name = "discountTypeIdDataGridViewTextBoxColumn";
            this.discountTypeIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.discountTypeIdDataGridViewTextBoxColumn.Visible = false;
            this.discountTypeIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemTypeIdDataGridViewTextBoxColumn
            // 
            this.itemTypeIdDataGridViewTextBoxColumn.DataPropertyName = "ItemTypeId";
            this.itemTypeIdDataGridViewTextBoxColumn.HeaderText = "ItemTypeId";
            this.itemTypeIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemTypeIdDataGridViewTextBoxColumn.Name = "itemTypeIdDataGridViewTextBoxColumn";
            this.itemTypeIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemTypeIdDataGridViewTextBoxColumn.Visible = false;
            this.itemTypeIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemCategoryIdDataGridViewTextBoxColumn
            // 
            this.itemCategoryIdDataGridViewTextBoxColumn.DataPropertyName = "ItemCategoryId";
            this.itemCategoryIdDataGridViewTextBoxColumn.HeaderText = "ItemCategoryId";
            this.itemCategoryIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemCategoryIdDataGridViewTextBoxColumn.Name = "itemCategoryIdDataGridViewTextBoxColumn";
            this.itemCategoryIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemCategoryIdDataGridViewTextBoxColumn.Visible = false;
            this.itemCategoryIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // restaurantMenuItemIdDataGridViewTextBoxColumn
            // 
            this.restaurantMenuItemIdDataGridViewTextBoxColumn.DataPropertyName = "RestaurantMenuItemId";
            this.restaurantMenuItemIdDataGridViewTextBoxColumn.HeaderText = "RestaurantMenuItemId";
            this.restaurantMenuItemIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.restaurantMenuItemIdDataGridViewTextBoxColumn.Name = "restaurantMenuItemIdDataGridViewTextBoxColumn";
            this.restaurantMenuItemIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.restaurantMenuItemIdDataGridViewTextBoxColumn.Visible = false;
            this.restaurantMenuItemIdDataGridViewTextBoxColumn.Width = 125;
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
            // discountDateDataGridViewTextBoxColumn
            // 
            this.discountDateDataGridViewTextBoxColumn.DataPropertyName = "DiscountDate";
            this.discountDateDataGridViewTextBoxColumn.HeaderText = "Datum dodavanja popusta";
            this.discountDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.discountDateDataGridViewTextBoxColumn.Name = "discountDateDataGridViewTextBoxColumn";
            this.discountDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.discountDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // discountValueDataGridViewTextBoxColumn
            // 
            this.discountValueDataGridViewTextBoxColumn.DataPropertyName = "DiscountValue";
            this.discountValueDataGridViewTextBoxColumn.HeaderText = "Iznos popusta";
            this.discountValueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.discountValueDataGridViewTextBoxColumn.Name = "discountValueDataGridViewTextBoxColumn";
            this.discountValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.discountValueDataGridViewTextBoxColumn.Width = 125;
            // 
            // activeDataGridViewTextBoxColumn
            // 
            this.activeDataGridViewTextBoxColumn.DataPropertyName = "Active";
            this.activeDataGridViewTextBoxColumn.HeaderText = "Aktivan";
            this.activeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.activeDataGridViewTextBoxColumn.Name = "activeDataGridViewTextBoxColumn";
            this.activeDataGridViewTextBoxColumn.ReadOnly = true;
            this.activeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.activeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.activeDataGridViewTextBoxColumn.Width = 125;
            // 
            // discountBindingSource
            // 
            this.discountBindingSource.DataSource = typeof(eRestoran.Model.Discount);
            // 
            // frmDiscountManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 467);
            this.Controls.Add(this.dgvD);
            this.Name = "frmDiscountManagment";
            this.Text = "frmDiscountManagment";
            this.Load += new System.EventHandler(this.frmDiscountManagment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvD;
        private System.Windows.Forms.BindingSource discountBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCategoryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn restaurantMenuItemIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountType;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeactivateDiscount;
    }
}