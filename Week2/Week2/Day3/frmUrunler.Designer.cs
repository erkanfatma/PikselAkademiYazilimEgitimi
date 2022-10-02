namespace Week2.Day3 {
    partial class frmUrunler {
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
            this.lblElemanSayisi = new System.Windows.Forms.Label();
            this.btnTekTekSil = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.lstUrunler = new System.Windows.Forms.ListBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtUrun = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblElemanSayisi
            // 
            this.lblElemanSayisi.AutoSize = true;
            this.lblElemanSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElemanSayisi.Location = new System.Drawing.Point(405, 354);
            this.lblElemanSayisi.Name = "lblElemanSayisi";
            this.lblElemanSayisi.Size = new System.Drawing.Size(201, 33);
            this.lblElemanSayisi.TabIndex = 11;
            this.lblElemanSayisi.Text = "Eleman Sayısı";
            // 
            // btnTekTekSil
            // 
            this.btnTekTekSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTekTekSil.Location = new System.Drawing.Point(129, 239);
            this.btnTekTekSil.Name = "btnTekTekSil";
            this.btnTekTekSil.Size = new System.Drawing.Size(232, 49);
            this.btnTekTekSil.TabIndex = 10;
            this.btnTekTekSil.Text = "Tek tek Sil";
            this.btnTekTekSil.UseVisualStyleBackColor = true;
            this.btnTekTekSil.Click += new System.EventHandler(this.btnTekTekSil_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Location = new System.Drawing.Point(129, 181);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(232, 51);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lstUrunler
            // 
            this.lstUrunler.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.ItemHeight = 31;
            this.lstUrunler.Location = new System.Drawing.Point(405, 64);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(266, 283);
            this.lstUrunler.TabIndex = 8;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.Location = new System.Drawing.Point(129, 118);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(232, 56);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtUrun
            // 
            this.txtUrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrun.Location = new System.Drawing.Point(129, 75);
            this.txtUrun.Name = "txtUrun";
            this.txtUrun.Size = new System.Drawing.Size(232, 38);
            this.txtUrun.TabIndex = 6;
            // 
            // frmUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblElemanSayisi);
            this.Controls.Add(this.btnTekTekSil);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lstUrunler);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtUrun);
            this.Name = "frmUrunler";
            this.Text = "frmUrunler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblElemanSayisi;
        private System.Windows.Forms.Button btnTekTekSil;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ListBox lstUrunler;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtUrun;
    }
}