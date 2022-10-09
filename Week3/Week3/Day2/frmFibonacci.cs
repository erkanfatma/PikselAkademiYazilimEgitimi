using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week3.Day2 {
    public partial class frmFibonacci : Form {
        public frmFibonacci() {
            InitializeComponent();
            //4. form
        }



        private void btnHesapla_Click(object sender, EventArgs e) {
            int count = Convert.ToInt32(txtSayi.Text);
            int sayi1 = 0;
            int sayi2 = 1;

            string fibonacciSayilari = "";

            for (int i = 0; i < count; i++) {
                fibonacciSayilari += " - " + sayi1;

                int oncekiIkiSayininToplami = sayi1 + sayi2;

                sayi1 = sayi2;
                sayi2 = oncekiIkiSayininToplami;
            }

            MessageBox.Show(fibonacciSayilari);
        }
    }
}
