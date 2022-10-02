namespace Week2.Day2 {
    partial class frmOdevRegex {
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEmailDogrulama = new System.Windows.Forms.Label();
            this.lblSifreDogrulama = new System.Windows.Forms.Label();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(155, 44);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 0;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(155, 89);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(100, 20);
            this.txtSifre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre";
            // 
            // lblEmailDogrulama
            // 
            this.lblEmailDogrulama.AutoSize = true;
            this.lblEmailDogrulama.Location = new System.Drawing.Point(314, 44);
            this.lblEmailDogrulama.Name = "lblEmailDogrulama";
            this.lblEmailDogrulama.Size = new System.Drawing.Size(35, 13);
            this.lblEmailDogrulama.TabIndex = 4;
            this.lblEmailDogrulama.Text = "label3";
            // 
            // lblSifreDogrulama
            // 
            this.lblSifreDogrulama.AutoSize = true;
            this.lblSifreDogrulama.Location = new System.Drawing.Point(317, 88);
            this.lblSifreDogrulama.Name = "lblSifreDogrulama";
            this.lblSifreDogrulama.Size = new System.Drawing.Size(35, 13);
            this.lblSifreDogrulama.TabIndex = 5;
            this.lblSifreDogrulama.Text = "label4";
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Location = new System.Drawing.Point(155, 157);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(75, 23);
            this.btnGirisYap.TabIndex = 6;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // frmOdevRegex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.lblSifreDogrulama);
            this.Controls.Add(this.lblEmailDogrulama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtEmail);
            this.Name = "frmOdevRegex";
            this.Text = "frmOdevRegex";
            this.Load += new System.EventHandler(this.frmOdevRegex_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEmailDogrulama;
        private System.Windows.Forms.Label lblSifreDogrulama;
        private System.Windows.Forms.Button btnGirisYap;
    }
}