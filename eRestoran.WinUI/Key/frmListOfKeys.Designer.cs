namespace eRestoran.WinUI.Key
{
    partial class frmListOfKeys
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.KeyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Key1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RestaurantId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumberOfKeys = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KeyId,
            this.Key1,
            this.RestaurantId,
            this.Active});
            this.dataGridView1.Location = new System.Drawing.Point(1, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(614, 397);
            this.dataGridView1.TabIndex = 0;
            // 
            // KeyId
            // 
            this.KeyId.DataPropertyName = "KeyId";
            this.KeyId.HeaderText = "Redni broj ključa";
            this.KeyId.MinimumWidth = 6;
            this.KeyId.Name = "KeyId";
            this.KeyId.ReadOnly = true;
            this.KeyId.Width = 125;
            // 
            // Key1
            // 
            this.Key1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Key1.DataPropertyName = "Key1";
            this.Key1.HeaderText = "Ključ";
            this.Key1.MinimumWidth = 6;
            this.Key1.Name = "Key1";
            this.Key1.ReadOnly = true;
            // 
            // RestaurantId
            // 
            this.RestaurantId.DataPropertyName = "RestaurantId";
            this.RestaurantId.HeaderText = "Restoran";
            this.RestaurantId.MinimumWidth = 6;
            this.RestaurantId.Name = "RestaurantId";
            this.RestaurantId.ReadOnly = true;
            this.RestaurantId.Visible = false;
            this.RestaurantId.Width = 125;
            // 
            // Active
            // 
            this.Active.DataPropertyName = "Active";
            this.Active.HeaderText = "Aktivan";
            this.Active.MinimumWidth = 6;
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            this.Active.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Broj aktivnih ključeva:";
            // 
            // txtNumberOfKeys
            // 
            this.txtNumberOfKeys.Location = new System.Drawing.Point(202, 19);
            this.txtNumberOfKeys.Name = "txtNumberOfKeys";
            this.txtNumberOfKeys.ReadOnly = true;
            this.txtNumberOfKeys.Size = new System.Drawing.Size(100, 22);
            this.txtNumberOfKeys.TabIndex = 2;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(440, 5);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(150, 45);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generiši nove ključeve";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // frmListOfKeys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 452);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtNumberOfKeys);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmListOfKeys";
            this.Text = "frmListOfKeys";
            this.Load += new System.EventHandler(this.frmListOfKeys_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RestaurantId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Active;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumberOfKeys;
        private System.Windows.Forms.Button btnGenerate;
    }
}