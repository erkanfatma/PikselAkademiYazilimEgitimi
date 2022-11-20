using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week5.Day2
{
    public partial class frmUcgenMetotlari : Form
    {
        public frmUcgenMetotlari()
        {
            InitializeComponent();
        }

        private void btnCevre_Click(object sender, EventArgs e) {
            int kenar1 = Convert.ToInt32(txtKenar1.Text);
            int kenar2 = Convert.ToInt32(txtKenar2.Text);
            int kenar3 = Convert.ToInt32(txtKenar3.Text);
            int cevresi = CevreHesapla(kenar1, kenar2, kenar3);
            SonucuYazdir(cevresi.ToString()); 
        } 
        private void btnAlan_Click(object sender, EventArgs e) {
            int kenar1 = Convert.ToInt32(txtKenar1.Text); 
            int yukseklik = Convert.ToInt32(txtYukseklik.Text);
            int sonuc = AlanHesapla(kenar1, yukseklik);
            SonucuYazdir(sonuc.ToString());
        } 
        public int CevreHesapla(int a, int b, int c) {
            return a + b + c;
        } 
        public int AlanHesapla(int taban, int yukseklik) {
            return taban * yukseklik / 2;
        }

        public void SonucuYazdir(string sonuc) {
            MessageBox.Show("Sonuc: " + sonuc);
        }
    }
}
