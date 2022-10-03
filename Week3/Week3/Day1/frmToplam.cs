using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week3.Day1 {
    public partial class frmToplam : Form {
        public frmToplam() {
            InitializeComponent();
            //3. form
        }

        private void btnHesapla_Click(object sender, EventArgs e) {
            try {
                int sayi1 = Convert.ToInt32(txtSayi1.Text);
                int sayi2 = Convert.ToInt32(txtSayi2.Text);
                int toplam = 0;

                if (sayi1 > sayi2) {
                    MessageBox.Show("Sayi1 sayi2den büyük olamaz");
                }
                else {

                    for (int i = sayi1; i < sayi2; i++) {
                        toplam = toplam + i;
                    }
                    MessageBox.Show(toplam.ToString());
                }
            }
            catch (Exception) {
                MessageBox.Show("Lütfen sayı girin");
            }
            
        }
    }
}
