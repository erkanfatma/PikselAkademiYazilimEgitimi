namespace Week2.Day2 {
    partial class frmHaftaIciHaftaSonu {
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
            this.lblGun = new System.Windows.Forms.Label();
            this.btnKontrolEt = new System.Windows.Forms.Button();
            this.txtGun = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblGun
            // 
            this.lblGun.AutoSize = true;
            this.lblGun.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGun.Location = new System.Drawing.Point(316, 271);
            this.lblGun.Name = "lblGun";
            this.lblGun.Size = new System.Drawing.Size(70, 33);
            this.lblGun.TabIndex = 8;
            this.lblGun.Text = "Gun";
            // 
            // btnKontrolEt
            // 
            this.btnKontrolEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKontrolEt.Location = new System.Drawing.Point(322, 191);
            this.btnKontrolEt.Name = "btnKontrolEt";
            this.btnKontrolEt.Size = new System.Drawing.Size(163, 64);
            this.btnKontrolEt.TabIndex = 7;
            this.btnKontrolEt.Text = "Kontrol Et";
            this.btnKontrolEt.UseVisualStyleBackColor = true;
            this.btnKontrolEt.Click += new System.EventHandler(this.btnKontrolEt_Click);
            // 
            // txtGun
            // 
            this.txtGun.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGun.Location = new System.Drawing.Point(322, 146);
            this.txtGun.Name = "txtGun";
            this.txtGun.Size = new System.Drawing.Size(100, 40);
            this.txtGun.TabIndex = 6;
            // 
            // frmHaftaIciHaftaSonu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGun);
            this.Controls.Add(this.btnKontrolEt);
            this.Controls.Add(this.txtGun);
            this.Name = "frmHaftaIciHaftaSonu";
            this.Text = "frmHaftaIciHaftaSonu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGun;
        private System.Windows.Forms.Button btnKontrolEt;
        private System.Windows.Forms.TextBox txtGun;
    }
}