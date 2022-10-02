namespace Week2.Day2 {
    partial class frmStringMetotlari {
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
            this.txtMetin = new System.Windows.Forms.TextBox();
            this.lblBoyutu = new System.Windows.Forms.Label();
            this.lblRenk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKontrolEt
            // 
            this.btnKontrolEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKontrolEt.Location = new System.Drawing.Point(290, 165);
            this.btnKontrolEt.Name = "btnKontrolEt";
            this.btnKontrolEt.Size = new System.Drawing.Size(201, 64);
            this.btnKontrolEt.TabIndex = 5;
            this.btnKontrolEt.Text = "Kontrol Et";
            this.btnKontrolEt.UseVisualStyleBackColor = true;
            this.btnKontrolEt.Click += new System.EventHandler(this.btnKontrolEt_Click);
            // 
            // txtMetin
            // 
            this.txtMetin.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMetin.Location = new System.Drawing.Point(290, 106);
            this.txtMetin.Name = "txtMetin";
            this.txtMetin.Size = new System.Drawing.Size(226, 40);
            this.txtMetin.TabIndex = 4;
            // 
            // lblBoyutu
            // 
            this.lblBoyutu.AutoSize = true;
            this.lblBoyutu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoyutu.Location = new System.Drawing.Point(284, 253);
            this.lblBoyutu.Name = "lblBoyutu";
            this.lblBoyutu.Size = new System.Drawing.Size(86, 31);
            this.lblBoyutu.TabIndex = 6;
            this.lblBoyutu.Text = "label1";
            // 
            // lblRenk
            // 
            this.lblRenk.AutoSize = true;
            this.lblRenk.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRenk.Location = new System.Drawing.Point(284, 313);
            this.lblRenk.Name = "lblRenk";
            this.lblRenk.Size = new System.Drawing.Size(86, 31);
            this.lblRenk.TabIndex = 7;
            this.lblRenk.Text = "label1";
            // 
            // frmStringMetotlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRenk);
            this.Controls.Add(this.lblBoyutu);
            this.Controls.Add(this.btnKontrolEt);
            this.Controls.Add(this.txtMetin);
            this.Name = "frmStringMetotlari";
            this.Text = "frmStringMetotlari";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnKontrolEt;
        private System.Windows.Forms.TextBox txtMetin;
        private System.Windows.Forms.Label lblBoyutu;
        private System.Windows.Forms.Label lblRenk;
    }
}