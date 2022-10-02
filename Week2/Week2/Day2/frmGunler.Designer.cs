namespace Week2.Day2 {
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnKontrolEt = new System.Windows.Forms.Button();
            this.txtDeger = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // btnKontrolEt
            // 
            this.btnKontrolEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKontrolEt.Location = new System.Drawing.Point(270, 182);
            this.btnKontrolEt.Name = "btnKontrolEt";
            this.btnKontrolEt.Size = new System.Drawing.Size(236, 76);
            this.btnKontrolEt.TabIndex = 4;
            this.btnKontrolEt.Text = "Kontrol Et";
            this.btnKontrolEt.UseVisualStyleBackColor = true;
            this.btnKontrolEt.Click += new System.EventHandler(this.btnKontrolEt_Click);
            // 
            // txtDeger
            // 
            this.txtDeger.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeger.Location = new System.Drawing.Point(270, 135);
            this.txtDeger.Name = "txtDeger";
            this.txtDeger.Size = new System.Drawing.Size(261, 40);
            this.txtDeger.TabIndex = 3;
            // 
            // frmGunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKontrolEt);
            this.Controls.Add(this.txtDeger);
            this.Name = "frmGunler";
            this.Text = "frmSwitchGunler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKontrolEt;
        private System.Windows.Forms.TextBox txtDeger;
    }
}