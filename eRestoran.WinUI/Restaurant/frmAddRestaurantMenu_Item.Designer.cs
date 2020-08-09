namespace eRestoran.WinUI.Restaurant
{
    partial class frmAddRestaurantMenu_Item
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
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtPortion = new System.Windows.Forms.ComboBox();
            this.txtCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.KM = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.RestaurantMenuItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSlika = new System.Windows.Forms.TextBox();
            this.Sl = new System.Windows.Forms.Label();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(145, 33);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(220, 22);
            this.txtItemName.TabIndex = 0;
            // 
            // txtPortion
            // 
            this.txtPortion.FormattingEnabled = true;
            this.txtPortion.Location = new System.Drawing.Point(145, 79);
            this.txtPortion.Name = "txtPortion";
            this.txtPortion.Size = new System.Drawing.Size(220, 24);
            this.txtPortion.TabIndex = 2;
            // 
            // txtCategory
            // 
            this.txtCategory.FormattingEnabled = true;
            this.txtCategory.Location = new System.Drawing.Point(145, 124);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(220, 24);
            this.txtCategory.TabIndex = 3;
            this.txtCategory.SelectedIndexChanged += new System.EventHandler(this.txtCategory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Naziv jela/pića:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cijena:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Porcija:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kategorija:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(668, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 51);
            this.button1.TabIndex = 8;
            this.button1.Text = "Dodaj stavku";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nudPrice
            // 
            this.nudPrice.DecimalPlaces = 1;
            this.nudPrice.Location = new System.Drawing.Point(145, 168);
            this.nudPrice.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(192, 22);
            this.nudPrice.TabIndex = 9;
            // 
            // KM
            // 
            this.KM.AutoSize = true;
            this.KM.Location = new System.Drawing.Point(337, 170);
            this.KM.Name = "KM";
            this.KM.Size = new System.Drawing.Size(28, 17);
            this.KM.TabIndex = 10;
            this.KM.Text = "KM";
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RestaurantMenuItemId,
            this.ItemName,
            this.Price,
            this.ItemCategoryName,
            this.QuantityName,
            this.Image,
            this.ItemCategoryId,
            this.QuantityId});
            this.dgvItems.Location = new System.Drawing.Point(2, 219);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersWidth = 51;
            this.dgvItems.RowTemplate.Height = 24;
            this.dgvItems.Size = new System.Drawing.Size(797, 231);
            this.dgvItems.TabIndex = 11;
            // 
            // RestaurantMenuItemId
            // 
            this.RestaurantMenuItemId.DataPropertyName = "RestaurantMenuItemId";
            this.RestaurantMenuItemId.HeaderText = "RestaurantMenuItemId";
            this.RestaurantMenuItemId.MinimumWidth = 6;
            this.RestaurantMenuItemId.Name = "RestaurantMenuItemId";
            this.RestaurantMenuItemId.ReadOnly = true;
            this.RestaurantMenuItemId.Visible = false;
            this.RestaurantMenuItemId.Width = 125;
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "Naziv stavke";
            this.ItemName.MinimumWidth = 6;
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 125;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Cijena";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 125;
            // 
            // ItemCategoryName
            // 
            this.ItemCategoryName.DataPropertyName = "ItemCategoryName";
            this.ItemCategoryName.HeaderText = "Kategorija";
            this.ItemCategoryName.MinimumWidth = 6;
            this.ItemCategoryName.Name = "ItemCategoryName";
            this.ItemCategoryName.ReadOnly = true;
            this.ItemCategoryName.Width = 125;
            // 
            // QuantityName
            // 
            this.QuantityName.DataPropertyName = "QuantityName";
            this.QuantityName.HeaderText = "Porcija";
            this.QuantityName.MinimumWidth = 6;
            this.QuantityName.Name = "QuantityName";
            this.QuantityName.ReadOnly = true;
            this.QuantityName.Width = 125;
            // 
            // Image
            // 
            this.Image.DataPropertyName = "Image";
            this.Image.HeaderText = "Slika";
            this.Image.MinimumWidth = 6;
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            this.Image.Width = 125;
            // 
            // ItemCategoryId
            // 
            this.ItemCategoryId.DataPropertyName = "ItemCategoryId";
            this.ItemCategoryId.HeaderText = "IDKAT";
            this.ItemCategoryId.MinimumWidth = 6;
            this.ItemCategoryId.Name = "ItemCategoryId";
            this.ItemCategoryId.ReadOnly = true;
            this.ItemCategoryId.Visible = false;
            this.ItemCategoryId.Width = 125;
            // 
            // QuantityId
            // 
            this.QuantityId.DataPropertyName = "QuantityId";
            this.QuantityId.HeaderText = "IDQ";
            this.QuantityId.MinimumWidth = 6;
            this.QuantityId.Name = "QuantityId";
            this.QuantityId.ReadOnly = true;
            this.QuantityId.Visible = false;
            this.QuantityId.Width = 125;
            // 
            // txtSlika
            // 
            this.txtSlika.Location = new System.Drawing.Point(447, 35);
            this.txtSlika.Name = "txtSlika";
            this.txtSlika.Size = new System.Drawing.Size(203, 22);
            this.txtSlika.TabIndex = 13;
            // 
            // Sl
            // 
            this.Sl.AutoSize = true;
            this.Sl.Location = new System.Drawing.Point(386, 35);
            this.Sl.Name = "Sl";
            this.Sl.Size = new System.Drawing.Size(42, 17);
            this.Sl.TabIndex = 14;
            this.Sl.Text = "Slika:";
            // 
            // btnAddImage
            // 
            this.btnAddImage.Location = new System.Drawing.Point(447, 73);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(111, 30);
            this.btnAddImage.TabIndex = 15;
            this.btnAddImage.Text = "Dodaj sliku";
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAddRestaurantMenu_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddImage);
            this.Controls.Add(this.Sl);
            this.Controls.Add(this.txtSlika);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.KM);
            this.Controls.Add(this.nudPrice);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtPortion);
            this.Controls.Add(this.txtItemName);
            this.Name = "frmAddRestaurantMenu_Item";
            this.Text = "frmAddRestaurantMenu_Item";
            this.Load += new System.EventHandler(this.frmAddRestaurantMenu_Item_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.ComboBox txtPortion;
        private System.Windows.Forms.ComboBox txtCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label KM;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn RestaurantMenuItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityId;
        private System.Windows.Forms.TextBox txtSlika;
        private System.Windows.Forms.Label Sl;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}