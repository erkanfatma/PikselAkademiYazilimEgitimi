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
    public partial class frmSayilar : Form {
        public frmSayilar() {
            InitializeComponent();
            //2.
        }

        private void btnYazdir_Click(object sender, EventArgs e) {
            //1den 100e kadar
            for (int i = 1; i < 100; i++) {
                lstSayilar1.Items.Add(i);
            }

            //100den 1e kadar
            for (int i = 100; i > 0; i--) {
                lstSayilar2.Items.Add(i);
            }

            //1den 100e kadar tek sayılar ve çift sayılar

            //for (int i = 0; i < 100; i=i+2) {
            //    lstTekSayilar.Items.Add(i);
            //}

            //for (int i = 1; i < 100; i+=2) {
            //    lstCiftSayilar.Items.Add(i);
            //}

            //for (int i = 1; i < 100; i++) {
            //    //çift 
            //    if (i % 2 == 0) {
            //        lstCiftSayilar.Items.Add(i);
            //    }
            //    //tek
            //    else {
            //        lstTekSayilar.Items.Add(i);
            //    }
            //}


            int sayi = Convert.ToInt32(txtSayi.Text);
            int toplam = 0; 
            for (int i = 0; i < sayi; i++) {
                lstSecilenSayiListesi.Items.Add(i);
            }
        }
    }
}
