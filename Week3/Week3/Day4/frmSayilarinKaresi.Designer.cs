namespace Week3.Day4 {
    partial class frmSayilarinKaresi {
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
            this.lstKareleri = new System.Windows.Forms.ListBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.lstKupleri = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstKareleri
            // 
            this.lstKareleri.FormattingEnabled = true;
            this.lstKareleri.Location = new System.Drawing.Point(383, 97);
            this.lstKareleri.Name = "lstKareleri";
            this.lstKareleri.Size = new System.Drawing.Size(120, 95);
            this.lstKareleri.TabIndex = 0;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(169, 169);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 1;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(169, 123);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(100, 20);
            this.txtSayi.TabIndex = 2;
            // 
            // lstKupleri
            // 
            this.lstKupleri.FormattingEnabled = true;
            this.lstKupleri.Location = new System.Drawing.Point(542, 97);
            this.lstKupleri.Name = "lstKupleri";
            this.lstKupleri.Size = new System.Drawing.Size(120, 95);
            this.lstKupleri.TabIndex = 3;
            // 
            // frmSayilarinKaresi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstKupleri);
            this.Controls.Add(this.txtSayi);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lstKareleri);
            this.Name = "frmSayilarinKaresi";
            this.Text = "frmSayilarinKaresi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstKareleri;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.ListBox lstKupleri;
    }
}