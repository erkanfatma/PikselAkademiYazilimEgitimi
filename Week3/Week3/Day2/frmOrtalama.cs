using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week3.Day2 {
    public partial class frmOrtalama : Form {
        public frmOrtalama() {
            InitializeComponent();
            //2. form
        }

        private void btnHesapla_Click(object sender, EventArgs e) {
            int sayi1 = Convert.ToInt32(txtSayi1.Text);
            int sayi2 = Convert.ToInt32(txtSayi2.Text);

            int toplamSayiAdedi = 0;
            int toplamlari = 0;
            for (int i = sayi1; i < sayi2; i++) {
                toplamSayiAdedi++;
                toplamlari += i;
            }

            MessageBox.Show("Toplamları : " + toplamlari + " - Ortalama : " + Convert.ToDouble(toplamlari / toplamSayiAdedi).ToString());
        }
    }
}
