namespace eRestoran.WinUI.Award
{
    partial class frmAddDiscount
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtVisitorName = new System.Windows.Forms.TextBox();
            this.cmbDT = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudDV = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.restaurantMenuItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantMenuItemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemCategoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemCategoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddDiscount = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantMenuItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime i prezime posjetioca:";
            // 
            // txtVisitorName
            // 
            this.txtVisitorName.Location = new System.Drawing.Point(391, 22);
            this.txtVisitorName.Name = "txtVisitorName";
            this.txtVisitorName.ReadOnly = true;
            this.txtVisitorName.Size = new System.Drawing.Size(187, 22);
            this.txtVisitorName.TabIndex = 1;
            // 
            // cmbDT
            // 
            this.cmbDT.FormattingEnabled = true;
            this.cmbDT.Location = new System.Drawing.Point(359, 73);
            this.cmbDT.Name = "cmbDT";
            this.cmbDT.Size = new System.Drawing.Size(246, 24);
            this.cmbDT.TabIndex = 2;
            this.cmbDT.SelectedIndexChanged += new System.EventHandler(this.cmbDT_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vrsta popusta:";
            // 
            // nudDV
            // 
            this.nudDV.DecimalPlaces = 2;
            this.nudDV.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudDV.Location = new System.Drawing.Point(409, 120);
            this.nudDV.Name = "nudDV";
            this.nudDV.Size = new System.Drawing.Size(135, 22);
            this.nudDV.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Iznos (npr. 0.10=10%):";
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AutoGenerateColumns = false;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.restaurantMenuItemIdDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.itemCategoryIdDataGridViewTextBoxColumn,
            this.itemCategoryNameDataGridViewTextBoxColumn,
            this.quantityIdDataGridViewTextBoxColumn,
            this.quantityNameDataGridViewTextBoxColumn,
            this.AddDiscount});
            this.dgvItems.DataSource = this.restaurantMenuItemBindingSource;
            this.dgvItems.Location = new System.Drawing.Point(1, 234);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersWidth = 51;
            this.dgvItems.RowTemplate.Height = 24;
            this.dgvItems.Size = new System.Drawing.Size(807, 251);
            this.dgvItems.TabIndex = 6;
            this.dgvItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 55);
            this.button1.TabIndex = 7;
            this.button1.Text = "Dodijeli popust";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(222, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(359, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pritisnuti, ukoliko vrsta popusta nije pojedinačna stavka!";
            // 
            // restaurantMenuItemBindingSource
            // 
            this.restaurantMenuItemBindingSource.DataSource = typeof(eRestoran.Model.RestaurantMenuItem);
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
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "Naziv stavke";
            this.itemNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 125;
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
            // itemCategoryNameDataGridViewTextBoxColumn
            // 
            this.itemCategoryNameDataGridViewTextBoxColumn.DataPropertyName = "ItemCategoryName";
            this.itemCategoryNameDataGridViewTextBoxColumn.HeaderText = "Naziv kategorije";
            this.itemCategoryNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemCategoryNameDataGridViewTextBoxColumn.Name = "itemCategoryNameDataGridViewTextBoxColumn";
            this.itemCategoryNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemCategoryNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityIdDataGridViewTextBoxColumn
            // 
            this.quantityIdDataGridViewTextBoxColumn.DataPropertyName = "QuantityId";
            this.quantityIdDataGridViewTextBoxColumn.HeaderText = "QuantityId";
            this.quantityIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityIdDataGridViewTextBoxColumn.Name = "quantityIdDataGridViewTextBoxColumn";
            this.quantityIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityIdDataGridViewTextBoxColumn.Visible = false;
            this.quantityIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityNameDataGridViewTextBoxColumn
            // 
            this.quantityNameDataGridViewTextBoxColumn.DataPropertyName = "QuantityName";
            this.quantityNameDataGridViewTextBoxColumn.HeaderText = "Porcija";
            this.quantityNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityNameDataGridViewTextBoxColumn.Name = "quantityNameDataGridViewTextBoxColumn";
            this.quantityNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // AddDiscount
            // 
            this.AddDiscount.HeaderText = "Dodijeli popust na stavku";
            this.AddDiscount.MinimumWidth = 6;
            this.AddDiscount.Name = "AddDiscount";
            this.AddDiscount.ReadOnly = true;
            this.AddDiscount.Text = "Dodijeli popust na stavku";
            this.AddDiscount.UseColumnTextForButtonValue = true;
            this.AddDiscount.Width = 125;
            // 
            // frmAddDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 483);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudDV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbDT);
            this.Controls.Add(this.txtVisitorName);
            this.Controls.Add(this.label1);
            this.Name = "frmAddDiscount";
            this.Text = "frmAddDiscount";
            this.Load += new System.EventHandler(this.frmAddDiscount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantMenuItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVisitorName;
        private System.Windows.Forms.ComboBox cmbDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudDV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.BindingSource restaurantMenuItemBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn restaurantMenuItemIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCategoryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCategoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn AddDiscount;
    }
}