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
    public partial class frmSayilariKarsilastirma : Form {
        public frmSayilariKarsilastirma() {
            InitializeComponent();
            //3. form
        }

        private void btnKontrolEt_Click(object sender, EventArgs e) {
            try {
                int sayi1 = Convert.ToInt32(txtSayi1.Text);
                int sayi2 = Convert.ToInt32(txtSayi2.Text);
                int sayi3 = Convert.ToInt32(txtSayi3.Text);

                if (sayi1 == sayi2 && sayi1 > sayi3) {
                    MessageBox.Show("Sayı 1 ve Sayı 2 eşit. Sayı 1&2 Sayı 3den büyük");
                }
                else if (sayi1 == sayi2 && sayi3 > sayi1) {
                    MessageBox.Show("Sayi1 ve Sayı 2 eşit. Sayı 1&2 sayı 3den küçük");
                }
                else if (sayi2 == sayi3 && sayi2 > sayi1) {
                    MessageBox.Show("Sayi2 ve sayi3 eşit. Sayi 2&3 sayı1den büyük");
                }
                else if (sayi2 == sayi3 && sayi1 > sayi2) {
                    MessageBox.Show("Sayi 2 ve sayi3 eşit. Sayi 2&3 sayi1den küçük");
                }
                else if (sayi1 == sayi3 && sayi1 > sayi2) {
                    MessageBox.Show("Sayi1 ve sayi3 eşit. Sayi1&3 sayi2den büyük");
                }
                else if (sayi1 == sayi3 && sayi2 > sayi1) {
                    MessageBox.Show("Sayi1 ve sayi3 eşit. Sayi1&3 sayi2den küçük");
                }
                else if (sayi1 > sayi2 && sayi1 > sayi3) {
                    MessageBox.Show("Sayı 1 hepsinden büyük");
                }
                else if (sayi2 > sayi1 && sayi2 > sayi3) {
                    MessageBox.Show("Sayı 2 hepsinden büyük");
                }
                else if (sayi3 > sayi1 && sayi3 > sayi2) {
                    MessageBox.Show("Sayı 3 hepsinden büyük");
                }
                else {
                    MessageBox.Show("Bütün sayılar eşit");
                }
            }
            catch (Exception) {
                MessageBox.Show("Lütfen sayı girin.");
            }
        }
    }
}
