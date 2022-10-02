namespace Week2.Day3 {
    partial class frmSinifYoklamasi {
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
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstDurumlari = new System.Windows.Forms.ListBox();
            this.lstOgrenciler = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOgrenciler = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtDurumu = new System.Windows.Forms.TextBox();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuzenle.Location = new System.Drawing.Point(32, 389);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(172, 51);
            this.btnDuzenle.TabIndex = 21;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Location = new System.Drawing.Point(32, 312);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(172, 50);
            this.btnSil.TabIndex = 20;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 33);
            this.label3.TabIndex = 19;
            this.label3.Text = "Durumu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 33);
            this.label1.TabIndex = 18;
            this.label1.Text = "Adı";
            // 
            // lstDurumlari
            // 
            this.lstDurumlari.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDurumlari.FormattingEnabled = true;
            this.lstDurumlari.ItemHeight = 33;
            this.lstDurumlari.Location = new System.Drawing.Point(535, 49);
            this.lstDurumlari.Name = "lstDurumlari";
            this.lstDurumlari.Size = new System.Drawing.Size(237, 301);
            this.lstDurumlari.TabIndex = 17;
            // 
            // lstOgrenciler
            // 
            this.lstOgrenciler.BackColor = System.Drawing.SystemColors.WindowText;
            this.lstOgrenciler.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOgrenciler.ForeColor = System.Drawing.Color.YellowGreen;
            this.lstOgrenciler.FormattingEnabled = true;
            this.lstOgrenciler.ItemHeight = 33;
            this.lstOgrenciler.Location = new System.Drawing.Point(279, 47);
            this.lstOgrenciler.Name = "lstOgrenciler";
            this.lstOgrenciler.Size = new System.Drawing.Size(216, 301);
            this.lstOgrenciler.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(532, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 33);
            this.label2.TabIndex = 15;
            this.label2.Text = "Yoklama Durumu";
            // 
            // lblOgrenciler
            // 
            this.lblOgrenciler.AutoSize = true;
            this.lblOgrenciler.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOgrenciler.Location = new System.Drawing.Point(273, 11);
            this.lblOgrenciler.Name = "lblOgrenciler";
            this.lblOgrenciler.Size = new System.Drawing.Size(151, 33);
            this.lblOgrenciler.TabIndex = 14;
            this.lblOgrenciler.Text = "Öğrenciler";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.Location = new System.Drawing.Point(32, 224);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(172, 59);
            this.btnKaydet.TabIndex = 13;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtDurumu
            // 
            this.txtDurumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDurumu.Location = new System.Drawing.Point(32, 167);
            this.txtDurumu.Name = "txtDurumu";
            this.txtDurumu.Size = new System.Drawing.Size(172, 40);
            this.txtDurumu.TabIndex = 12;
            // 
            // txtIsim
            // 
            this.txtIsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIsim.Location = new System.Drawing.Point(32, 58);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(172, 40);
            this.txtIsim.TabIndex = 11;
            // 
            // frmSinifYoklamasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstDurumlari);
            this.Controls.Add(this.lstOgrenciler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOgrenciler);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtDurumu);
            this.Controls.Add(this.txtIsim);
            this.Name = "frmSinifYoklamasi";
            this.Text = "frmSinifYoklamasi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstDurumlari;
        private System.Windows.Forms.ListBox lstOgrenciler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOgrenciler;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtDurumu;
        private System.Windows.Forms.TextBox txtIsim;
    }
}