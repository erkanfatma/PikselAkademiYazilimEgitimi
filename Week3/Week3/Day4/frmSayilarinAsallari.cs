using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week3.Day4 {
    public partial class frmSayilarinAsallari : Form {
        public frmSayilarinAsallari() {
            InitializeComponent();
            //2. form
        }

        private void btnHesapla_Click(object sender, EventArgs e) {
            int sayi1 = Convert.ToInt32(txtSayi1.Text);
            int sayi2 = Convert.ToInt32(txtSayi2.Text);

            for (int i = sayi1; i < sayi2; i++) {

                int counter = 0;
                for (int j = 0; j < sayi1; j++) {
                    if (sayi1 % i == 0) {
                        counter++;
                    }
                }
                 
                if (counter == 2) {
                    lstAsalSayilar.Items.Add(sayi1);
                }
            }
        }
    }
}
