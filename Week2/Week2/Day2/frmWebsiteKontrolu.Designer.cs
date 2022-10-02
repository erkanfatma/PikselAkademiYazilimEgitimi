namespace Week2.Day2 {
    partial class frmWebsiteKontrolu {
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
            this.lblMetin = new System.Windows.Forms.Label();
            this.txtMetin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKontrolEt
            // 
            this.btnKontrolEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKontrolEt.Location = new System.Drawing.Point(291, 237);
            this.btnKontrolEt.Name = "btnKontrolEt";
            this.btnKontrolEt.Size = new System.Drawing.Size(194, 64);
            this.btnKontrolEt.TabIndex = 5;
            this.btnKontrolEt.Text = "Kontrol Et";
            this.btnKontrolEt.UseVisualStyleBackColor = true;
            this.btnKontrolEt.Click += new System.EventHandler(this.btnKontrolEt_Click);
            // 
            // lblMetin
            // 
            this.lblMetin.AutoSize = true;
            this.lblMetin.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetin.Location = new System.Drawing.Point(291, 149);
            this.lblMetin.Name = "lblMetin";
            this.lblMetin.Size = new System.Drawing.Size(93, 33);
            this.lblMetin.TabIndex = 4;
            this.lblMetin.Text = "label1";
            // 
            // txtMetin
            // 
            this.txtMetin.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMetin.Location = new System.Drawing.Point(291, 187);
            this.txtMetin.Name = "txtMetin";
            this.txtMetin.Size = new System.Drawing.Size(219, 40);
            this.txtMetin.TabIndex = 3;
            // 
            // frmWebsiteKontrolu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKontrolEt);
            this.Controls.Add(this.lblMetin);
            this.Controls.Add(this.txtMetin);
            this.Name = "frmWebsiteKontrolu";
            this.Text = "frmWebsiteKontrolu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKontrolEt;
        private System.Windows.Forms.Label lblMetin;
        private System.Windows.Forms.TextBox txtMetin;
    }
}