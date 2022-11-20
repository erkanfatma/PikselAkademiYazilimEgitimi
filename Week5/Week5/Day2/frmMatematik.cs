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
    public partial class frmMatematik : Form
    {
        public frmMatematik()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int sonuc = 0;
            int sayi1 = Convert.ToInt32(txtSayi1.Text);
            int sayi2 = Convert.ToInt32(txtSayi2.Text);
            string islem = txtIslem.Text;

            if (islem == "+") {
                sonuc =Topla(sayi1,sayi2); 
            }
            else if (islem == "-") {
                sonuc = Cikar(sayi1,sayi2); 
            }
            else if (islem == "*")  {
                sonuc = Carp(sayi1, sayi2); 
            }
            else if (islem == "/") {
                sonuc = Bol(sayi1, sayi2); 
            } 
            SonucuYazdir(sonuc.ToString()); 
        }

        public int Topla(int a, int b) {  return a + b; } 
        public int Cikar(int a, int b) { return a - b; } 
        public int Carp(int a, int b) { return a * b; } 
        public int Bol(int a, int b) { return a / b; } 
        public void SonucuYazdir(string sonuc) {
            MessageBox.Show("Sonuc : " + sonuc);
        }
    }
}
