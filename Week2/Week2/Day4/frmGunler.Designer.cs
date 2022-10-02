namespace Week2.Day4 {
    partial class frmGunler {
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstHaftasonu = new System.Windows.Forms.ListBox();
            this.btnKontrolEt = new System.Windows.Forms.Button();
            this.txtGun = new System.Windows.Forms.TextBox();
            this.lstHaftaici = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(504, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 33);
            this.label2.TabIndex = 11;
            this.label2.Text = "Hafta sonu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "Hafta içi";
            // 
            // lstHaftasonu
            // 
            this.lstHaftasonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstHaftasonu.FormattingEnabled = true;
            this.lstHaftasonu.ItemHeight = 33;
            this.lstHaftasonu.Location = new System.Drawing.Point(510, 81);
            this.lstHaftasonu.Name = "lstHaftasonu";
            this.lstHaftasonu.Size = new System.Drawing.Size(175, 202);
            this.lstHaftasonu.TabIndex = 9;
            // 
            // btnKontrolEt
            // 
            this.btnKontrolEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKontrolEt.Location = new System.Drawing.Point(62, 163);
            this.btnKontrolEt.Name = "btnKontrolEt";
            this.btnKontrolEt.Size = new System.Drawing.Size(183, 53);
            this.btnKontrolEt.TabIndex = 8;
            this.btnKontrolEt.Text = "Kontrol Et";
            this.btnKontrolEt.UseVisualStyleBackColor = true;
            this.btnKontrolEt.Click += new System.EventHandler(this.btnKontrolEt_Click);
            // 
            // txtGun
            // 
            this.txtGun.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGun.Location = new System.Drawing.Point(62, 105);
            this.txtGun.Name = "txtGun";
            this.txtGun.Size = new System.Drawing.Size(195, 40);
            this.txtGun.TabIndex = 7;
            // 
            // lstHaftaici
            // 
            this.lstHaftaici.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstHaftaici.FormattingEnabled = true;
            this.lstHaftaici.ItemHeight = 33;
            this.lstHaftaici.Location = new System.Drawing.Point(329, 81);
            this.lstHaftaici.Name = "lstHaftaici";
            this.lstHaftaici.Size = new System.Drawing.Size(175, 202);
            this.lstHaftaici.TabIndex = 6;
            // 
            // frmGunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstHaftasonu);
            this.Controls.Add(this.btnKontrolEt);
            this.Controls.Add(this.txtGun);
            this.Controls.Add(this.lstHaftaici);
            this.Name = "frmGunler";
            this.Text = "frmGunler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstHaftasonu;
        private System.Windows.Forms.Button btnKontrolEt;
        private System.Windows.Forms.TextBox txtGun;
        private System.Windows.Forms.ListBox lstHaftaici;
    }
}