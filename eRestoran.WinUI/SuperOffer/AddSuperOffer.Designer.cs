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
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.RestaurantMenuItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Akcija = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naziv super ponude:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(491, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datum početka super ponude:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(497, 126);
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
            this.dtpOfferStart.Location = new System.Drawing.Point(696, 71);
            this.dtpOfferStart.Name = "dtpOfferStart";
            this.dtpOfferStart.Size = new System.Drawing.Size(283, 22);
            this.dtpOfferStart.TabIndex = 5;
            // 
            // dtpOfferEnd
            // 
            this.dtpOfferEnd.Location = new System.Drawing.Point(696, 126);
            this.dtpOfferEnd.Name = "dtpOfferEnd";
            this.dtpOfferEnd.Size = new System.Drawing.Size(283, 22);
            this.dtpOfferEnd.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(400, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Iznos popusta (npr. 0.10 = 10%)";
            // 
            // nudDiscount
            // 
            this.nudDiscount.DecimalPlaces = 2;
            this.nudDiscount.Location = new System.Drawing.Point(465, 209);
            this.nudDiscount.Name = "nudDiscount";
            this.nudDiscount.Size = new System.Drawing.Size(89, 22);
            this.nudDiscount.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(862, 186);
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
            this.label5.Location = new System.Drawing.Point(12, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Vrsta super ponude:";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(220, 128);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(242, 24);
            this.cmbType.TabIndex = 14;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RestaurantMenuItemId,
            this.ItemName,
            this.Price,
            this.ItemCategoryId,
            this.ItemCategoryName,
            this.QuantityId,
            this.QuantityName,
            this.Image,
            this.Akcija});
            this.dgvProducts.Location = new System.Drawing.Point(5, 258);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(994, 279);
            this.dgvProducts.TabIndex = 15;
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            // 
            // RestaurantMenuItemId
            // 
            this.RestaurantMenuItemId.DataPropertyName = "RestaurantMenuItemId";
            this.RestaurantMenuItemId.HeaderText = "Id";
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
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Cijena";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // ItemCategoryId
            // 
            this.ItemCategoryId.DataPropertyName = "ItemCategoryId";
            this.ItemCategoryId.HeaderText = "CAT";
            this.ItemCategoryId.MinimumWidth = 6;
            this.ItemCategoryId.Name = "ItemCategoryId";
            this.ItemCategoryId.Visible = false;
            this.ItemCategoryId.Width = 125;
            // 
            // ItemCategoryName
            // 
            this.ItemCategoryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemCategoryName.DataPropertyName = "ItemCategoryName";
            this.ItemCategoryName.HeaderText = "Kategorija";
            this.ItemCategoryName.MinimumWidth = 6;
            this.ItemCategoryName.Name = "ItemCategoryName";
            // 
            // QuantityId
            // 
            this.QuantityId.DataPropertyName = "QuantityId";
            this.QuantityId.HeaderText = "Q";
            this.QuantityId.MinimumWidth = 6;
            this.QuantityId.Name = "QuantityId";
            this.QuantityId.Visible = false;
            this.QuantityId.Width = 125;
            // 
            // QuantityName
            // 
            this.QuantityName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QuantityName.DataPropertyName = "QuantityName";
            this.QuantityName.HeaderText = "Porcija";
            this.QuantityName.MinimumWidth = 6;
            this.QuantityName.Name = "QuantityName";
            // 
            // Image
            // 
            this.Image.DataPropertyName = "Image";
            this.Image.HeaderText = "Slika";
            this.Image.MinimumWidth = 6;
            this.Image.Name = "Image";
            this.Image.Visible = false;
            this.Image.Width = 125;
            // 
            // Akcija
            // 
            this.Akcija.DataPropertyName = "Akcija";
            this.Akcija.HeaderText = "Akcija";
            this.Akcija.MinimumWidth = 6;
            this.Akcija.Name = "Akcija";
            this.Akcija.Text = "Dodaj super ponudu";
            this.Akcija.UseColumnTextForButtonValue = true;
            this.Akcija.Width = 125;
            // 
            // AddSuperOffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 538);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn RestaurantMenuItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityId;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Image;
        private System.Windows.Forms.DataGridViewButtonColumn Akcija;
    }
}