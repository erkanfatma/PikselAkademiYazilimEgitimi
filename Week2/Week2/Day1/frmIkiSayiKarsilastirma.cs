using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week2.Day1 {
    public partial class frmIkiSayiKarsilastirma : Form {
        public frmIkiSayiKarsilastirma() {
            InitializeComponent();
            //1. form
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                int sayi1 = Convert.ToInt32(txtSayi1.Text);
                int sayi2 = Convert.ToInt32(txtSayi2.Text);

                if (sayi1 > sayi2) {
                    MessageBox.Show("Sayı 1 büyük");
                }
                else if (sayi1 == sayi2) {
                    MessageBox.Show("Eşittir");
                }
                else {
                    MessageBox.Show("Sayı 2 büyük");
                }
            }
            catch (Exception) {
                MessageBox.Show("Geçerli bir sayı girin");
            }
        }
    }
}
