using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week2.Day3 {
    public partial class frmUrunler : Form {
        public frmUrunler() {
            InitializeComponent();
            //1. form
        }

        int counter = 0;
        private void btnKaydet_Click(object sender, EventArgs e) {
            string urun = txtUrun.Text;
            lstUrunler.Items.Add(urun);
            txtUrun.Text = "";
            counter++;

            lblElemanSayisi.Text = "Eleman sayısı : " + counter;
            //lblElemanSayisi.Text = "Eleman sayısı : " + lstUrunler.Items.Count ;
        }

        private void btnSil_Click(object sender, EventArgs e) {
            lstUrunler.Items.Clear();
            counter = 0;
            lblElemanSayisi.Text = "Eleman sayısı : " + counter;
        }

        private void btnTekTekSil_Click(object sender, EventArgs e) {
            int sirasi = lstUrunler.SelectedIndex;
            lstUrunler.Items.RemoveAt(sirasi);
            counter--;
            lblElemanSayisi.Text = "Eleman sayısı : " + counter;
        }
    }
}
