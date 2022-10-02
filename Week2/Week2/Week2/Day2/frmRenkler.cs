using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week2.Day2 {
    public partial class frmRenkler : Form {
        public frmRenkler() {
            InitializeComponent();
            //2. form
        }

        private void btnKontrolEt_Click(object sender, EventArgs e) {
            int deger = Convert.ToInt32(txtSayi.Text);

            switch (deger) {
                case 1:
                    lblColor.BackColor = Color.Yellow;
                    break;
                case 2:
                    lblColor.BackColor = Color.Green;
                    break;
                case 3:
                    lblColor.BackColor = Color.Red;
                    break;
                case 4:
                    lblColor.BackColor = Color.Pink;
                    break;
                default:
                    MessageBox.Show("Yanlış değer girdiniz");
                    break;
            }
        }
    }
}
