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
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(306, 77);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(220, 22);
            this.txtItemName.TabIndex = 0;
            // 
            // txtPortion
            // 
            this.txtPortion.FormattingEnabled = true;
            this.txtPortion.Location = new System.Drawing.Point(306, 190);
            this.txtPortion.Name = "txtPortion";
            this.txtPortion.Size = new System.Drawing.Size(220, 24);
            this.txtPortion.TabIndex = 2;
            // 
            // txtCategory
            // 
            this.txtCategory.FormattingEnabled = true;
            this.txtCategory.Location = new System.Drawing.Point(306, 314);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(220, 24);
            this.txtCategory.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Naziv jela / pića";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cijena";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Porcija";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kategorija";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(654, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 51);
            this.button1.TabIndex = 8;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // nudPrice
            // 
            this.nudPrice.DecimalPlaces = 1;
            this.nudPrice.Location = new System.Drawing.Point(306, 416);
            this.nudPrice.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(197, 22);
            this.nudPrice.TabIndex = 9;
            // 
            // KM
            // 
            this.KM.AutoSize = true;
            this.KM.Location = new System.Drawing.Point(509, 418);
            this.KM.Name = "KM";
            this.KM.Size = new System.Drawing.Size(28, 17);
            this.KM.TabIndex = 10;
            this.KM.Text = "KM";
            // 
            // frmAddRestaurantMenu_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}