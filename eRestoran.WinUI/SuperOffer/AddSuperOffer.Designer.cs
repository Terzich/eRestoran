namespace eRestoran.WinUI.SuperOffer
{
    partial class AddSuperOffer
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSuperOfferName = new System.Windows.Forms.TextBox();
            this.dtpOfferStart = new System.Windows.Forms.DateTimePicker();
            this.dtpOfferEnd = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.nudDiscount = new System.Windows.Forms.NumericUpDown();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.RestaurantMenuItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RestaurantMenuItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slika = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(422, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dodaj novu super ponudu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naziv super ponude:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datum početka super ponude:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Datum kraja super ponude:";
            // 
            // txtSuperOfferName
            // 
            this.txtSuperOfferName.Location = new System.Drawing.Point(220, 73);
            this.txtSuperOfferName.Name = "txtSuperOfferName";
            this.txtSuperOfferName.Size = new System.Drawing.Size(242, 22);
            this.txtSuperOfferName.TabIndex = 4;
            // 
            // dtpOfferStart
            // 
            this.dtpOfferStart.Location = new System.Drawing.Point(220, 123);
            this.dtpOfferStart.Name = "dtpOfferStart";
            this.dtpOfferStart.Size = new System.Drawing.Size(242, 22);
            this.dtpOfferStart.TabIndex = 5;
            // 
            // dtpOfferEnd
            // 
            this.dtpOfferEnd.Location = new System.Drawing.Point(220, 172);
            this.dtpOfferEnd.Name = "dtpOfferEnd";
            this.dtpOfferEnd.Size = new System.Drawing.Size(242, 22);
            this.dtpOfferEnd.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(483, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Iznos popusta (npr. 0.10 = 10%)";
            // 
            // nudDiscount
            // 
            this.nudDiscount.DecimalPlaces = 2;
            this.nudDiscount.Location = new System.Drawing.Point(696, 175);
            this.nudDiscount.Name = "nudDiscount";
            this.nudDiscount.Size = new System.Drawing.Size(283, 22);
            this.nudDiscount.TabIndex = 10;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RestaurantMenuItemId,
            this.RestaurantMenuItemName,
            this.QuantityName,
            this.Price,
            this.CategoryName,
            this.ItemCategoryId,
            this.QuantityId,
            this.Slika});
            this.dgvProducts.Location = new System.Drawing.Point(-2, 263);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(1005, 278);
            this.dgvProducts.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(886, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 66);
            this.button1.TabIndex = 12;
            this.button1.Text = "Dodaj super ponudu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(483, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tip za koji važi super ponuda:";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(696, 81);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(283, 24);
            this.cmbType.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(483, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Kategorija za koju važi ponuda:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(696, 128);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(283, 24);
            this.cmbCategory.TabIndex = 16;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Green;
            this.label9.Location = new System.Drawing.Point(266, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(482, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Napomena: Super ponudu je moguće dodati i bez odabira tipa ili kategorije!";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(897, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "*opcionalno";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Green;
            this.label10.Location = new System.Drawing.Point(897, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "*opcionalno";
            // 
            // RestaurantMenuItemId
            // 
            this.RestaurantMenuItemId.DataPropertyName = "RestaurantMenuItemId";
            this.RestaurantMenuItemId.HeaderText = "Id";
            this.RestaurantMenuItemId.MinimumWidth = 6;
            this.RestaurantMenuItemId.Name = "RestaurantMenuItemId";
            this.RestaurantMenuItemId.ReadOnly = true;
            this.RestaurantMenuItemId.Visible = false;
            this.RestaurantMenuItemId.Width = 125;
            // 
            // RestaurantMenuItemName
            // 
            this.RestaurantMenuItemName.DataPropertyName = "ItemName";
            this.RestaurantMenuItemName.HeaderText = "Naziv stavke";
            this.RestaurantMenuItemName.MinimumWidth = 6;
            this.RestaurantMenuItemName.Name = "RestaurantMenuItemName";
            this.RestaurantMenuItemName.ReadOnly = true;
            this.RestaurantMenuItemName.Width = 125;
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
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Cijena (u KM)";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 125;
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "ItemCategoryName";
            this.CategoryName.HeaderText = "Kategorija";
            this.CategoryName.MinimumWidth = 6;
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            this.CategoryName.Width = 125;
            // 
            // ItemCategoryId
            // 
            this.ItemCategoryId.DataPropertyName = "ItemCategoryId";
            this.ItemCategoryId.HeaderText = "CatId";
            this.ItemCategoryId.MinimumWidth = 6;
            this.ItemCategoryId.Name = "ItemCategoryId";
            this.ItemCategoryId.ReadOnly = true;
            this.ItemCategoryId.Visible = false;
            this.ItemCategoryId.Width = 125;
            // 
            // QuantityId
            // 
            this.QuantityId.DataPropertyName = "QuantityId";
            this.QuantityId.HeaderText = "IdQua";
            this.QuantityId.MinimumWidth = 6;
            this.QuantityId.Name = "QuantityId";
            this.QuantityId.ReadOnly = true;
            this.QuantityId.Visible = false;
            this.QuantityId.Width = 125;
            // 
            // Slika
            // 
            this.Slika.DataPropertyName = "Image";
            this.Slika.HeaderText = "Slika";
            this.Slika.MinimumWidth = 6;
            this.Slika.Name = "Slika";
            this.Slika.ReadOnly = true;
            this.Slika.Width = 125;
            // 
            // AddSuperOffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 538);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.nudDiscount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpOfferEnd);
            this.Controls.Add(this.dtpOfferStart);
            this.Controls.Add(this.txtSuperOfferName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddSuperOffer";
            this.Text = "AddSuperOffer";
            this.Load += new System.EventHandler(this.AddSuperOffer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSuperOfferName;
        private System.Windows.Forms.DateTimePicker dtpOfferStart;
        private System.Windows.Forms.DateTimePicker dtpOfferEnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudDiscount;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn RestaurantMenuItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RestaurantMenuItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Slika;
    }
}