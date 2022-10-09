namespace Week3.Day3 {
    partial class frmHiz {
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
            this.txtHiz = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lstHiz = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtHiz
            // 
            this.txtHiz.Location = new System.Drawing.Point(108, 57);
            this.txtHiz.Name = "txtHiz";
            this.txtHiz.Size = new System.Drawing.Size(100, 20);
            this.txtHiz.TabIndex = 0;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(108, 110);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 1;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lstHiz
            // 
            this.lstHiz.FormattingEnabled = true;
            this.lstHiz.Location = new System.Drawing.Point(411, 71);
            this.lstHiz.Name = "lstHiz";
            this.lstHiz.Size = new System.Drawing.Size(120, 95);
            this.lstHiz.TabIndex = 2;
            // 
            // frmHiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstHiz);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtHiz);
            this.Name = "frmHiz";
            this.Text = "frmHiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHiz;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.ListBox lstHiz;
    }
}