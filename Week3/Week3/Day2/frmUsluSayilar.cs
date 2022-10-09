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
    public partial class frmUsluSayilar : Form {
        public frmUsluSayilar() {
            InitializeComponent();
            //3. form
        }

        private void btnHesapla_Click(object sender, EventArgs e) {
            int sayi = Convert.ToInt32(txtSayi1.Text);
            int ussu = Convert.ToInt32(txtSayi2.Text);

            int sonuc = 1;
            for (int i = 1; i <= ussu; i++) {
                sonuc = sonuc * sayi;
            }
        }
    }
}
