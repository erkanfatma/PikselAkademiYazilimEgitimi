namespace Week3.Day1 {
    partial class frmDonguler {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.lstSayilar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(150, 85);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(100, 20);
            this.txtSayi.TabIndex = 0;
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(150, 135);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(75, 23);
            this.btnYazdir.TabIndex = 1;
            this.btnYazdir.Text = "Yazdir";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // lstSayilar
            // 
            this.lstSayilar.FormattingEnabled = true;
            this.lstSayilar.Location = new System.Drawing.Point(395, 97);
            this.lstSayilar.Name = "lstSayilar";
            this.lstSayilar.Size = new System.Drawing.Size(120, 95);
            this.lstSayilar.TabIndex = 2;
            // 
            // frmDonguler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstSayilar);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.txtSayi);
            this.Name = "frmDonguler";
            this.Text = "frmDonguler";
            this.Load += new System.EventHandler(this.frmDonguler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.ListBox lstSayilar;
    }
}