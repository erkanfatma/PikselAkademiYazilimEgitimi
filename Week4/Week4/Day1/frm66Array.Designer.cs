namespace Week4.Day1
{
    partial class frm66Array
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnKontrolEt = new System.Windows.Forms.Button();
            this.lstArrays = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnKontrolEt
            // 
            this.btnKontrolEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKontrolEt.Location = new System.Drawing.Point(76, 153);
            this.btnKontrolEt.Name = "btnKontrolEt";
            this.btnKontrolEt.Size = new System.Drawing.Size(228, 72);
            this.btnKontrolEt.TabIndex = 0;
            this.btnKontrolEt.Text = "Kontrol Et";
            this.btnKontrolEt.UseVisualStyleBackColor = true;
            this.btnKontrolEt.Click += new System.EventHandler(this.btnKontrolEt_Click);
            // 
            // lstArrays
            // 
            this.lstArrays.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstArrays.FormattingEnabled = true;
            this.lstArrays.ItemHeight = 52;
            this.lstArrays.Location = new System.Drawing.Point(439, 31);
            this.lstArrays.Name = "lstArrays";
            this.lstArrays.Size = new System.Drawing.Size(301, 264);
            this.lstArrays.TabIndex = 1;
            // 
            // frm66Array
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstArrays);
            this.Controls.Add(this.btnKontrolEt);
            this.Name = "frm66Array";
            this.Text = "frm66Array";
            this.Load += new System.EventHandler(this.frm66Array_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKontrolEt;
        private System.Windows.Forms.ListBox lstArrays;
    }
}