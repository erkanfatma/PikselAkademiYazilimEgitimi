namespace Week1.Day4 {
    partial class frmSartlar {
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
            this.btnMesajYazdir = new System.Windows.Forms.Button();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnIslem = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMesajYazdir
            // 
            this.btnMesajYazdir.Location = new System.Drawing.Point(497, 203);
            this.btnMesajYazdir.Name = "btnMesajYazdir";
            this.btnMesajYazdir.Size = new System.Drawing.Size(75, 23);
            this.btnMesajYazdir.TabIndex = 9;
            this.btnMesajYazdir.Text = "Mesaj Yaz";
            this.btnMesajYazdir.UseVisualStyleBackColor = true;
            this.btnMesajYazdir.Click += new System.EventHandler(this.btnMesajYazdir_Click);
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(497, 166);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(100, 20);
            this.txtIsim.TabIndex = 8;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(203, 166);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 7;
            this.txtNumber.TextChanged += new System.EventHandler(this.txtNumber_TextChanged);
            // 
            // btnIslem
            // 
            this.btnIslem.Location = new System.Drawing.Point(214, 212);
            this.btnIslem.Name = "btnIslem";
            this.btnIslem.Size = new System.Drawing.Size(75, 23);
            this.btnIslem.TabIndex = 6;
            this.btnIslem.Text = "İşlem";
            this.btnIslem.UseVisualStyleBackColor = true;
            this.btnIslem.Click += new System.EventHandler(this.btnIslem_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(232, 272);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(38, 13);
            this.lblSonuc.TabIndex = 5;
            this.lblSonuc.Text = "Sonuç";
            // 
            // frmSartlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMesajYazdir);
            this.Controls.Add(this.txtIsim);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.btnIslem);
            this.Controls.Add(this.lblSonuc);
            this.Name = "frmSartlar";
            this.Text = "frmSartlar";
            this.Load += new System.EventHandler(this.frmSartlar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMesajYazdir;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnIslem;
        private System.Windows.Forms.Label lblSonuc;
    }
}