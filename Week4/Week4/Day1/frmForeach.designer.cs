namespace Week4.Day1
{
    partial class frmForeach
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
            this.lstIsimler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstIsimler
            // 
            this.lstIsimler.FormattingEnabled = true;
            this.lstIsimler.ItemHeight = 20;
            this.lstIsimler.Location = new System.Drawing.Point(424, 66);
            this.lstIsimler.Name = "lstIsimler";
            this.lstIsimler.Size = new System.Drawing.Size(120, 84);
            this.lstIsimler.TabIndex = 0;
            // 
            // frmForeach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstIsimler);
            this.Name = "frmForeach";
            this.Text = "frmForeach";
            this.Load += new System.EventHandler(this.frmForeach_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstIsimler;
    }
}