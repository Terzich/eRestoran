namespace eRestoran.WinUI.Restaurant
{
    partial class frmShowRestaurantMenuItems
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
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RestaurantMenuItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemQuantityId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(295, 74);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(332, 24);
            this.cmbCategory.TabIndex = 0;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Odaberite kategoriju za koju zelite pregledati stavke menija:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RestaurantMenuItemId,
            this.ItemName,
            this.ItemCategoryName,
            this.Quantity,
            this.Price,
            this.ItemCategoryId,
            this.ItemQuantityId,
            this.Image});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(914, 338);
            this.dataGridView1.TabIndex = 2;
            // 
            // RestaurantMenuItemId
            // 
            this.RestaurantMenuItemId.DataPropertyName = "RestaurantMenuItemId";
            this.RestaurantMenuItemId.HeaderText = "RestaurantMenuItemId";
            this.RestaurantMenuItemId.MinimumWidth = 6;
            this.RestaurantMenuItemId.Name = "RestaurantMenuItemId";
            this.RestaurantMenuItemId.Visible = false;
            this.RestaurantMenuItemId.Width = 125;
            // 
            // ItemName
            // 
            this.ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "Naziv stavke";
            this.ItemName.MinimumWidth = 6;
            this.ItemName.Name = "ItemName";
            // 
            // ItemCategoryName
            // 
            this.ItemCategoryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemCategoryName.DataPropertyName = "ItemCategoryName";
            this.ItemCategoryName.HeaderText = "Naziv kategorije";
            this.ItemCategoryName.MinimumWidth = 6;
            this.ItemCategoryName.Name = "ItemCategoryName";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "QuantityName";
            this.Quantity.HeaderText = "Porcija";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 125;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Cijena (u KM)";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // ItemCategoryId
            // 
            this.ItemCategoryId.DataPropertyName = "ItemCategoryId";
            this.ItemCategoryId.HeaderText = "ICID";
            this.ItemCategoryId.MinimumWidth = 6;
            this.ItemCategoryId.Name = "ItemCategoryId";
            this.ItemCategoryId.Visible = false;
            this.ItemCategoryId.Width = 125;
            // 
            // ItemQuantityId
            // 
            this.ItemQuantityId.DataPropertyName = "QuantityId";
            this.ItemQuantityId.HeaderText = "ItemQuantityId";
            this.ItemQuantityId.MinimumWidth = 6;
            this.ItemQuantityId.Name = "ItemQuantityId";
            this.ItemQuantityId.Visible = false;
            this.ItemQuantityId.Width = 125;
            // 
            // Image
            // 
            this.Image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Image.DataPropertyName = "Image";
            this.Image.HeaderText = "Slika";
            this.Image.MinimumWidth = 6;
            this.Image.Name = "Image";
            this.Image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Image.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmShowRestaurantMenuItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 465);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCategory);
            this.Name = "frmShowRestaurantMenuItems";
            this.Text = "frmShowRestaurantMenuItems";
            this.Load += new System.EventHandler(this.frmShowRestaurantMenuItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RestaurantMenuItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemQuantityId;
        private System.Windows.Forms.DataGridViewImageColumn Image;
    }
}