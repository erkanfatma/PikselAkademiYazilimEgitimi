namespace Week1.Day4 {
    partial class frmNotHesaplama {
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
            this.lblSonuc = new System.Windows.Forms.Label();
            this.btnKontrolEt = new System.Windows.Forms.Button();
            this.txtNot = new System.Windows.Forms.TextBox();
            this.lblNot = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(346, 255);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(38, 13);
            this.lblSonuc.TabIndex = 7;
            this.lblSonuc.Text = "Sonuç";
            // 
            // btnKontrolEt
            // 
            this.btnKontrolEt.Location = new System.Drawing.Point(460, 183);
            this.btnKontrolEt.Name = "btnKontrolEt";
            this.btnKontrolEt.Size = new System.Drawing.Size(75, 23);
            this.btnKontrolEt.TabIndex = 6;
            this.btnKontrolEt.Text = "Kontrol Et";
            this.btnKontrolEt.UseVisualStyleBackColor = true;
            this.btnKontrolEt.Click += new System.EventHandler(this.btnKontrolEt_Click);
            // 
            // txtNot
            // 
            this.txtNot.Location = new System.Drawing.Point(337, 187);
            this.txtNot.Name = "txtNot";
            this.txtNot.Size = new System.Drawing.Size(100, 20);
            this.txtNot.TabIndex = 5;
            // 
            // lblNot
            // 
            this.lblNot.AutoSize = true;
            this.lblNot.Location = new System.Drawing.Point(266, 187);
            this.lblNot.Name = "lblNot";
            this.lblNot.Size = new System.Drawing.Size(47, 13);
            this.lblNot.TabIndex = 4;
            this.lblNot.Text = "Notunuz";
            // 
            // frmNotHesaplama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnKontrolEt);
            this.Controls.Add(this.txtNot);
            this.Controls.Add(this.lblNot);
            this.Name = "frmNotHesaplama";
            this.Text = "frmSinif";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button btnKontrolEt;
        private System.Windows.Forms.TextBox txtNot;
        private System.Windows.Forms.Label lblNot;
    }
}