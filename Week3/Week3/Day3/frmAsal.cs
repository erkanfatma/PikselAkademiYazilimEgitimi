using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week3.Day3 {
    public partial class frmAsal : Form {
        public frmAsal() {
            InitializeComponent();
            //3. form
        }

        private void btnHesapla_Click(object sender, EventArgs e) {
            int sayi = Convert.ToInt32(txtSayi.Text);

            int counter = 0;
            for (int i = 1; i <= sayi; i++) {
                if (sayi % i == 0) {
                    counter++;
                }
            }

            if (counter == 2) {
                MessageBox.Show("Asal sayıdır.");
            }
            else {
                MessageBox.Show("Asal sayı değildir.");
            }
        }
    }
}
