using System;
using System.Windows.Forms;

namespace Week2.WeekendHomeworks {
    public partial class frmAlisveris : Form {
        public frmAlisveris() {
            InitializeComponent();
        }

        double gomlekfiyati, pantolonfiyati, elbisefiyati;


        private void txtMusterininParasi_TextChanged(object sender, EventArgs e) {
            if (txtMusterininParasi.Text != "") {
                txtGomlekFiyati.Enabled = false;
                txtElbiseFiyati.Enabled = false;
                txtPantolonFiyati.Enabled = false;
            }
        }

        private void txtElbiseFiyati_TextChanged(object sender, EventArgs e) {
            try {
                elbisefiyati = Convert.ToDouble(txtElbiseFiyati.Text);
            }
            catch (Exception) {
                MessageBox.Show("Lütfen geçerli fiyat girin");
            }
        }

        private void txtPantolonFiyati_TextChanged(object sender, EventArgs e) {
            try {
                pantolonfiyati = Convert.ToDouble(txtPantolonFiyati.Text);
            }
            catch (Exception) {
                MessageBox.Show("Lütfen geçerli fiyat girin");
            }
        }

        private void txtGomlekFiyati_TextChanged(object sender, EventArgs e) {
            try {
                gomlekfiyati = Convert.ToDouble(txtGomlekFiyati.Text);
            }
            catch (Exception) {
                MessageBox.Show("Lütfen geçerli fiyat girin");
            }
        }

        private void btnSatinAl_Click(object sender, EventArgs e) {
            try {
                double musterininparasi = Convert.ToDouble(txtMusterininParasi.Text);
                int gomlekadedi = Convert.ToInt32(txtGomlekAdedi.Text);
                int elbiseadedi = Convert.ToInt32(txtElbiseAdedi.Text);
                int pantolonadedi = Convert.ToInt32(txtPantolonAdedi.Text);
                double toplamtutar = gomlekfiyati * gomlekadedi + elbisefiyati * elbiseadedi + pantolonfiyati * pantolonadedi;

                if (musterininparasi >= toplamtutar) {
                    if (toplamtutar >= 100 && toplamtutar < 200) {
                        toplamtutar -= toplamtutar * 0.1;
                    }
                    else if (toplamtutar >= 200 && toplamtutar < 300) {
                        toplamtutar -= toplamtutar * 0.2;
                    }
                    else if (toplamtutar >= 300) {
                        toplamtutar -= toplamtutar * 0.3;
                    }

                    lstTutar.Items.Add((gomlekadedi + pantolonadedi + elbiseadedi).ToString() + " - " + toplamtutar.ToString() + "₺");
                    lstMusteriler.Items.Add(txtMusterininAdi.Text + " - " + musterininparasi.ToString() + "₺");
                }
                else {
                    MessageBox.Show("Paranız yetmedi.");
                }
            }
            catch (Exception) {
                MessageBox.Show("Geçersiz veri girdiniz. Tekrar kontrol edin.");
            }
   
        }

   
    }
}
