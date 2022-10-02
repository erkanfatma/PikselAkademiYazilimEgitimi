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
    public partial class frmPozitifNegatif : Form {
        public frmPozitifNegatif() {
            InitializeComponent();
            //2. form
        }

        private void btnKontrol_Click(object sender, EventArgs e) {
            try {
                int sayi = Convert.ToInt32(txtSayi.Text);

                if (sayi > 0) {
                    MessageBox.Show("Pozitif sayı");
                }
                else if (sayi < 0) {
                    MessageBox.Show("Negatif sayı");
                }
                else {
                    MessageBox.Show("Sıfır");
                }
            }
            catch (Exception) {
                MessageBox.Show("Lütfen sayı giriniz.");
            }
        }
    }
}
