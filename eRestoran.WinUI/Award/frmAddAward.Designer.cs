namespace eRestoran.WinUI.Award
{
    partial class frmAddAward
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
            this.txtVisitorName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAwardDescription = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime i prezime posjetioca:";
            // 
            // txtVisitorName
            // 
            this.txtVisitorName.BackColor = System.Drawing.SystemColors.Menu;
            this.txtVisitorName.Location = new System.Drawing.Point(240, 73);
            this.txtVisitorName.Name = "txtVisitorName";
            this.txtVisitorName.ReadOnly = true;
            this.txtVisitorName.Size = new System.Drawing.Size(165, 22);
            this.txtVisitorName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Opis nagrade:";
            // 
            // txtAwardDescription
            // 
            this.txtAwardDescription.Location = new System.Drawing.Point(23, 178);
            this.txtAwardDescription.Name = "txtAwardDescription";
            this.txtAwardDescription.Size = new System.Drawing.Size(434, 22);
            this.txtAwardDescription.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.Location = new System.Drawing.Point(183, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Dodaj nagradu posjetiocu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAddAward
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 270);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAwardDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVisitorName);
            this.Controls.Add(this.label1);
            this.Name = "frmAddAward";
            this.Text = "frmAddAward";
            this.Load += new System.EventHandler(this.frmAddAward_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVisitorName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAwardDescription;
        private System.Windows.Forms.Button button1;
    }
}