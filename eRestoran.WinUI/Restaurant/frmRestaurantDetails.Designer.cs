namespace eRestoran.WinUI.Restaurant
{
    partial class frmRestaurantDetails
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
            this.txtRestaurantName = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpOpenAt = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpCloseAt = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.pbR = new System.Windows.Forms.PictureBox();
            this.nudNumberOfTables = new System.Windows.Forms.NumericUpDown();
            this.txtSlika = new System.Windows.Forms.TextBox();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRestaurantName
            // 
            this.txtRestaurantName.Location = new System.Drawing.Point(58, 83);
            this.txtRestaurantName.Name = "txtRestaurantName";
            this.txtRestaurantName.Size = new System.Drawing.Size(232, 22);
            this.txtRestaurantName.TabIndex = 0;
            this.txtRestaurantName.Validating += new System.ComponentModel.CancelEventHandler(this.txtRestaurantName_Validating);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(58, 168);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(232, 22);
            this.txtCity.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(58, 248);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(232, 22);
            this.txtAddress.TabIndex = 2;
            this.txtAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddress_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Naziv restorana";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Grad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Adresa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(569, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Broj stolova";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(689, 378);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 60);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Sačuvaj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpOpenAt
            // 
            this.dtpOpenAt.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpOpenAt.Location = new System.Drawing.Point(153, 340);
            this.dtpOpenAt.Name = "dtpOpenAt";
            this.dtpOpenAt.Size = new System.Drawing.Size(115, 22);
            this.dtpOpenAt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Vrijeme otvaranja";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(292, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Vrijeme zatvaranja";
            // 
            // dtpCloseAt
            // 
            this.dtpCloseAt.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpCloseAt.Location = new System.Drawing.Point(423, 342);
            this.dtpCloseAt.Name = "dtpCloseAt";
            this.dtpCloseAt.Size = new System.Drawing.Size(115, 22);
            this.dtpCloseAt.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(339, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Promijeni grad";
            // 
            // cmbCity
            // 
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(305, 166);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(159, 24);
            this.cmbCity.TabIndex = 15;
            // 
            // pbR
            // 
            this.pbR.Location = new System.Drawing.Point(523, 12);
            this.pbR.Name = "pbR";
            this.pbR.Size = new System.Drawing.Size(265, 236);
            this.pbR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbR.TabIndex = 16;
            this.pbR.TabStop = false;
            // 
            // nudNumberOfTables
            // 
            this.nudNumberOfTables.Location = new System.Drawing.Point(668, 340);
            this.nudNumberOfTables.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudNumberOfTables.Name = "nudNumberOfTables";
            this.nudNumberOfTables.Size = new System.Drawing.Size(120, 22);
            this.nudNumberOfTables.TabIndex = 17;
            this.nudNumberOfTables.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // txtSlika
            // 
            this.txtSlika.Location = new System.Drawing.Point(523, 273);
            this.txtSlika.Name = "txtSlika";
            this.txtSlika.Size = new System.Drawing.Size(165, 22);
            this.txtSlika.TabIndex = 18;
            // 
            // btnAddImage
            // 
            this.btnAddImage.Location = new System.Drawing.Point(694, 268);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(107, 32);
            this.btnAddImage.TabIndex = 19;
            this.btnAddImage.Text = "Dodaj sliku";
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmRestaurantDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddImage);
            this.Controls.Add(this.txtSlika);
            this.Controls.Add(this.nudNumberOfTables);
            this.Controls.Add(this.pbR);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpCloseAt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpOpenAt);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtRestaurantName);
            this.Name = "frmRestaurantDetails";
            this.Text = "RestaurantDetails";
            this.Load += new System.EventHandler(this.RestaurantDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRestaurantName;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtpOpenAt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpCloseAt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.PictureBox pbR;
        private System.Windows.Forms.NumericUpDown nudNumberOfTables;
        private System.Windows.Forms.TextBox txtSlika;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}