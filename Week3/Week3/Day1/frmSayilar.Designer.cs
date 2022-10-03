namespace Week3.Day1 {
    partial class frmSayilar {
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
            this.lstSayilar1 = new System.Windows.Forms.ListBox();
            this.lstSayilar2 = new System.Windows.Forms.ListBox();
            this.lstTekSayilar = new System.Windows.Forms.ListBox();
            this.lstCiftSayilar = new System.Windows.Forms.ListBox();
            this.lstSecilenSayiListesi = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtSayi
            // 
            this.txtSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSayi.Location = new System.Drawing.Point(133, 43);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(100, 40);
            this.txtSayi.TabIndex = 0;
            // 
            // btnYazdir
            // 
            this.btnYazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYazdir.Location = new System.Drawing.Point(112, 119);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(163, 69);
            this.btnYazdir.TabIndex = 1;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // lstSayilar1
            // 
            this.lstSayilar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSayilar1.FormattingEnabled = true;
            this.lstSayilar1.ItemHeight = 33;
            this.lstSayilar1.Location = new System.Drawing.Point(310, 84);
            this.lstSayilar1.Name = "lstSayilar1";
            this.lstSayilar1.Size = new System.Drawing.Size(188, 169);
            this.lstSayilar1.TabIndex = 2;
            // 
            // lstSayilar2
            // 
            this.lstSayilar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSayilar2.FormattingEnabled = true;
            this.lstSayilar2.ItemHeight = 33;
            this.lstSayilar2.Location = new System.Drawing.Point(522, 84);
            this.lstSayilar2.Name = "lstSayilar2";
            this.lstSayilar2.Size = new System.Drawing.Size(176, 169);
            this.lstSayilar2.TabIndex = 3;
            // 
            // lstTekSayilar
            // 
            this.lstTekSayilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTekSayilar.FormattingEnabled = true;
            this.lstTekSayilar.ItemHeight = 33;
            this.lstTekSayilar.Location = new System.Drawing.Point(310, 302);
            this.lstTekSayilar.Name = "lstTekSayilar";
            this.lstTekSayilar.Size = new System.Drawing.Size(176, 169);
            this.lstTekSayilar.TabIndex = 5;
            // 
            // lstCiftSayilar
            // 
            this.lstCiftSayilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCiftSayilar.FormattingEnabled = true;
            this.lstCiftSayilar.ItemHeight = 33;
            this.lstCiftSayilar.Location = new System.Drawing.Point(510, 302);
            this.lstCiftSayilar.Name = "lstCiftSayilar";
            this.lstCiftSayilar.Size = new System.Drawing.Size(188, 169);
            this.lstCiftSayilar.TabIndex = 4;
            // 
            // lstSecilenSayiListesi
            // 
            this.lstSecilenSayiListesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSecilenSayiListesi.FormattingEnabled = true;
            this.lstSecilenSayiListesi.ItemHeight = 33;
            this.lstSecilenSayiListesi.Location = new System.Drawing.Point(67, 274);
            this.lstSecilenSayiListesi.Name = "lstSecilenSayiListesi";
            this.lstSecilenSayiListesi.Size = new System.Drawing.Size(176, 169);
            this.lstSecilenSayiListesi.TabIndex = 6;
            // 
            // frmSayilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 603);
            this.Controls.Add(this.lstSecilenSayiListesi);
            this.Controls.Add(this.lstTekSayilar);
            this.Controls.Add(this.lstCiftSayilar);
            this.Controls.Add(this.lstSayilar2);
            this.Controls.Add(this.lstSayilar1);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.txtSayi);
            this.Name = "frmSayilar";
            this.Text = "frmSayilar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.ListBox lstSayilar1;
        private System.Windows.Forms.ListBox lstSayilar2;
        private System.Windows.Forms.ListBox lstTekSayilar;
        private System.Windows.Forms.ListBox lstCiftSayilar;
        private System.Windows.Forms.ListBox lstSecilenSayiListesi;
    }
}