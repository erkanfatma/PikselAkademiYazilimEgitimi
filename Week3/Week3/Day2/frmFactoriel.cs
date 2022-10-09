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
    public partial class frmFactoriel : Form {
        public frmFactoriel() {
            InitializeComponent();
            //1. form
        }

        private void btnHesapla_Click(object sender, EventArgs e) {
            int sayi = Convert.ToInt32(txtSayi.Text);
            int sonuc = 1;

            for (int i = 1; i <= sayi; i++) {
                sonuc = sonuc * i;
            }

            MessageBox.Show(sonuc.ToString()); ;
        }
    }
}
