using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week1.Day3 {
    public partial class frmOdevHesapMakinesi : Form {
        public frmOdevHesapMakinesi() {
            InitializeComponent();
            //4. form
        }

        //İşlemler
        bool islemTanimliMi = false;
        private void btnEsittir_Click(object sender, EventArgs e) {
            double sayi1 = Convert.ToDouble(txtSayi1.Text);
            double sayi2 = Convert.ToDouble(txtSayi2.Text);

            if (lblIslem.Text == "+") {
                lblSonuc.Text = Convert.ToString(sayi1 + sayi2);
            }
            else if (lblIslem.Text == "-") {
                lblSonuc.Text = Convert.ToString(sayi1 - sayi2);
            }
            else if (lblIslem.Text == "*") {
                lblSonuc.Text = Convert.ToString(sayi1 * sayi2);
            }
            else if (lblIslem.Text == "/") {
                lblSonuc.Text = Convert.ToString(sayi1 / sayi2);
            }
            else {
                MessageBox.Show("Geçersiz işlem");
            }
        }

        private void btnToplama_Click(object sender, EventArgs e) {
            islemTanimliMi = true;
            lblIslem.Text = "+";
        }

        private void btnCikarma_Click(object sender, EventArgs e) {
            islemTanimliMi = true;
            lblIslem.Text = "-";
        }

        private void btnCarpma_Click(object sender, EventArgs e) {
            islemTanimliMi = true;
            lblIslem.Text = "*";
        }

        private void btnBolme_Click(object sender, EventArgs e) {
            islemTanimliMi = true;
            lblIslem.Text = "/";
        }

        //Sayilar
        private void btnSifir_Click(object sender, EventArgs e) {
            if (islemTanimliMi) {
                txtSayi2.Text += "0";
            }
            else {
                txtSayi1.Text += "0";
            }
        }

        private void btnBir_Click(object sender, EventArgs e) {
            if (islemTanimliMi) {
                txtSayi2.Text += "1";
            }
            else {
                txtSayi1.Text += "1";
            }
        }

        private void btnİki_Click(object sender, EventArgs e) {
            if (islemTanimliMi) {
                txtSayi2.Text += "2";
            }
            else {
                txtSayi1.Text += "2";
            }
        }

        private void btnUc_Click(object sender, EventArgs e) {
            if (islemTanimliMi) {
                txtSayi2.Text += "3";
            }
            else {
                txtSayi1.Text += "3";
            }
        }

        private void btnDort_Click(object sender, EventArgs e) {
            if (islemTanimliMi) {
                txtSayi2.Text += "4";
            }
            else {
                txtSayi1.Text += "4";
            }
        }

        private void btnBes_Click(object sender, EventArgs e) {
            if (islemTanimliMi) {
                txtSayi2.Text += "5";
            }
            else {
                txtSayi1.Text += "5";
            }
        }

        private void btnAlti_Click(object sender, EventArgs e) {
            if (islemTanimliMi) {
                txtSayi2.Text += "6";
            }
            else {
                txtSayi1.Text += "6";
            }
        }

        private void btnYedi_Click(object sender, EventArgs e) {
            if (islemTanimliMi) {
                txtSayi2.Text += "7";
            }
            else {
                txtSayi1.Text += "7";
            }
        }

        private void btnSekiz_Click(object sender, EventArgs e) {
            if (islemTanimliMi) {
                txtSayi2.Text += "8";
            }
            else {
                txtSayi1.Text += "8";
            }
        }

        private void btnDokuz_Click(object sender, EventArgs e) {
            if (islemTanimliMi) {
                txtSayi2.Text += "9";
            }
            else {
                txtSayi1.Text += "9";
            }
        }

    }
}
