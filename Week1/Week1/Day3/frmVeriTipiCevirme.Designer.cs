namespace Week1.Day3 {
    partial class frmVeriTipiCevirme {
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
            this.btnBol = new System.Windows.Forms.Button();
            this.btnCikar = new System.Windows.Forms.Button();
            this.btnCarp = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnSum = new System.Windows.Forms.Button();
            this.lblNumber2 = new System.Windows.Forms.Label();
            this.lblNumber1 = new System.Windows.Forms.Label();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBol
            // 
            this.btnBol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBol.Location = new System.Drawing.Point(502, 229);
            this.btnBol.Name = "btnBol";
            this.btnBol.Size = new System.Drawing.Size(170, 37);
            this.btnBol.TabIndex = 17;
            this.btnBol.Text = "Böl";
            this.btnBol.UseVisualStyleBackColor = true;
            this.btnBol.Click += new System.EventHandler(this.btnBol_Click);
            // 
            // btnCikar
            // 
            this.btnCikar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCikar.Location = new System.Drawing.Point(502, 177);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(170, 37);
            this.btnCikar.TabIndex = 16;
            this.btnCikar.Text = "Çıkar";
            this.btnCikar.UseVisualStyleBackColor = true;
            this.btnCikar.Click += new System.EventHandler(this.btnCikar_Click);
            // 
            // btnCarp
            // 
            this.btnCarp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarp.Location = new System.Drawing.Point(294, 230);
            this.btnCarp.Name = "btnCarp";
            this.btnCarp.Size = new System.Drawing.Size(170, 37);
            this.btnCarp.TabIndex = 15;
            this.btnCarp.Text = "Çarp";
            this.btnCarp.UseVisualStyleBackColor = true;
            this.btnCarp.Click += new System.EventHandler(this.btnCarp_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(186, 267);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(55, 20);
            this.lblResult.TabIndex = 14;
            this.lblResult.Text = "Sonuç";
            // 
            // btnSum
            // 
            this.btnSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSum.Location = new System.Drawing.Point(294, 177);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(170, 37);
            this.btnSum.TabIndex = 13;
            this.btnSum.Text = "Topla";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // lblNumber2
            // 
            this.lblNumber2.AutoSize = true;
            this.lblNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber2.Location = new System.Drawing.Point(186, 126);
            this.lblNumber2.Name = "lblNumber2";
            this.lblNumber2.Size = new System.Drawing.Size(52, 20);
            this.lblNumber2.TabIndex = 12;
            this.lblNumber2.Text = "Sayı 2";
            // 
            // lblNumber1
            // 
            this.lblNumber1.AutoSize = true;
            this.lblNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber1.Location = new System.Drawing.Point(183, 78);
            this.lblNumber1.Name = "lblNumber1";
            this.lblNumber1.Size = new System.Drawing.Size(52, 20);
            this.lblNumber1.TabIndex = 11;
            this.lblNumber1.Text = "Sayı 1";
            // 
            // txtNumber2
            // 
            this.txtNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber2.Location = new System.Drawing.Point(269, 126);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(195, 26);
            this.txtNumber2.TabIndex = 10;
            // 
            // txtNumber1
            // 
            this.txtNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber1.Location = new System.Drawing.Point(269, 72);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(195, 26);
            this.txtNumber1.TabIndex = 9;
            // 
            // frmVeriTipiCevirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBol);
            this.Controls.Add(this.btnCikar);
            this.Controls.Add(this.btnCarp);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.lblNumber2);
            this.Controls.Add(this.lblNumber1);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Name = "frmVeriTipiCevirme";
            this.Text = "frmVeriTipiCevirme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBol;
        private System.Windows.Forms.Button btnCikar;
        private System.Windows.Forms.Button btnCarp;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Label lblNumber2;
        private System.Windows.Forms.Label lblNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.TextBox txtNumber1;
    }
}