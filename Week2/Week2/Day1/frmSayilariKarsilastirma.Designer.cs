namespace Week2.Day1 {
    partial class frmSayilariKarsilastirma {
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
            this.btnKontrolEt = new System.Windows.Forms.Button();
            this.lblSayi3 = new System.Windows.Forms.Label();
            this.lblSayi2 = new System.Windows.Forms.Label();
            this.lblSayi1 = new System.Windows.Forms.Label();
            this.txtSayi3 = new System.Windows.Forms.TextBox();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKontrolEt
            // 
            this.btnKontrolEt.Location = new System.Drawing.Point(386, 285);
            this.btnKontrolEt.Name = "btnKontrolEt";
            this.btnKontrolEt.Size = new System.Drawing.Size(75, 23);
            this.btnKontrolEt.TabIndex = 13;
            this.btnKontrolEt.Text = "Kontrol Et";
            this.btnKontrolEt.UseVisualStyleBackColor = true;
            this.btnKontrolEt.Click += new System.EventHandler(this.btnKontrolEt_Click);
            // 
            // lblSayi3
            // 
            this.lblSayi3.AutoSize = true;
            this.lblSayi3.Location = new System.Drawing.Point(321, 248);
            this.lblSayi3.Name = "lblSayi3";
            this.lblSayi3.Size = new System.Drawing.Size(36, 13);
            this.lblSayi3.TabIndex = 12;
            this.lblSayi3.Text = "Sayı 3";
            // 
            // lblSayi2
            // 
            this.lblSayi2.AutoSize = true;
            this.lblSayi2.Location = new System.Drawing.Point(318, 195);
            this.lblSayi2.Name = "lblSayi2";
            this.lblSayi2.Size = new System.Drawing.Size(36, 13);
            this.lblSayi2.TabIndex = 11;
            this.lblSayi2.Text = "Sayi 2";
            // 
            // lblSayi1
            // 
            this.lblSayi1.AutoSize = true;
            this.lblSayi1.Location = new System.Drawing.Point(315, 143);
            this.lblSayi1.Name = "lblSayi1";
            this.lblSayi1.Size = new System.Drawing.Size(36, 13);
            this.lblSayi1.TabIndex = 10;
            this.lblSayi1.Text = "Sayı 1";
            // 
            // txtSayi3
            // 
            this.txtSayi3.Location = new System.Drawing.Point(386, 242);
            this.txtSayi3.Name = "txtSayi3";
            this.txtSayi3.Size = new System.Drawing.Size(100, 20);
            this.txtSayi3.TabIndex = 9;
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(386, 195);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(100, 20);
            this.txtSayi2.TabIndex = 8;
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(386, 143);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(100, 20);
            this.txtSayi1.TabIndex = 7;
            // 
            // frmSayilariKarsilastirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKontrolEt);
            this.Controls.Add(this.lblSayi3);
            this.Controls.Add(this.lblSayi2);
            this.Controls.Add(this.lblSayi1);
            this.Controls.Add(this.txtSayi3);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.txtSayi1);
            this.Name = "frmSayilariKarsilastirma";
            this.Text = "frmSayilariKarsilastirma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKontrolEt;
        private System.Windows.Forms.Label lblSayi3;
        private System.Windows.Forms.Label lblSayi2;
        private System.Windows.Forms.Label lblSayi1;
        private System.Windows.Forms.TextBox txtSayi3;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.TextBox txtSayi1;
    }
}