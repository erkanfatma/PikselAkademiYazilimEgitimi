namespace Week1.WeekendHomeworks {
    partial class frmTekCift {
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
            this.btnSonuc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSonuc.Location = new System.Drawing.Point(339, 328);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(96, 31);
            this.lblSonuc.TabIndex = 7;
            this.lblSonuc.Text = "Sonuç";
            // 
            // btnSonuc
            // 
            this.btnSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSonuc.Location = new System.Drawing.Point(312, 226);
            this.btnSonuc.Name = "btnSonuc";
            this.btnSonuc.Size = new System.Drawing.Size(176, 63);
            this.btnSonuc.TabIndex = 6;
            this.btnSonuc.Text = "Kontrol Et";
            this.btnSonuc.UseVisualStyleBackColor = true;
            this.btnSonuc.Click += new System.EventHandler(this.btnSonuc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sayı";
            // 
            // txtSayi
            // 
            this.txtSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSayi.Location = new System.Drawing.Point(321, 142);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(156, 38);
            this.txtSayi.TabIndex = 4;
            // 
            // frmTekCift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnSonuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSayi);
            this.Name = "frmTekCift";
            this.Text = "frmTekCift";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button btnSonuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSayi;
    }
}