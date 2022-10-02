using System;
using System.Windows.Forms;

namespace Week1.WeekendHomeworks {
    public partial class frmKurHesaplama : Form {
        public frmKurHesaplama() {
            InitializeComponent();
            //2. form
        }

        private void txtCurrentTL_TextChanged(object sender, EventArgs e) {
            if (txtCurrentTL.Text != "") {
                if (txtKurTL.Text != "") {
                    txtResultTL.Text = (Convert.ToDouble(txtCurrentTL.Text) / Convert.ToDouble(txtKurTL.Text)).ToString();
                }

                if (txtKurDollar.Text != "") {
                    txtResultDollar.Text = (Convert.ToDouble(txtCurrentTL.Text) / Convert.ToDouble(txtKurDollar.Text)).ToString();
                }

                if (txtKurEuro.Text != "") {
                    txtResultEuro.Text = (Convert.ToDouble(txtCurrentTL.Text) / Convert.ToDouble(txtKurEuro.Text)).ToString();
                }

                if (txtKurSterlin.Text != "") {
                    txtResultSterlin.Text = (Convert.ToDouble(txtCurrentTL.Text) / Convert.ToDouble(txtKurSterlin.Text)).ToString();
                }
            }
        }

        private void txtKurTL_TextChanged(object sender, EventArgs e) {
            if (txtKurTL.Text != "" && txtCurrentTL.Text != "") {
                txtResultTL.Text = (Convert.ToDouble(txtCurrentTL.Text) / Convert.ToDouble(txtKurTL.Text)).ToString();
            }
        }

        private void txtKurDollar_TextChanged(object sender, EventArgs e) {
            if (txtKurDollar.Text != "" && txtCurrentTL.Text != "") {
                txtResultTL.Text = (Convert.ToDouble(txtCurrentTL.Text) / Convert.ToDouble(txtKurDollar.Text)).ToString();
            }
        }

        private void txtKurEuro_TextChanged(object sender, EventArgs e) {
            if (txtKurEuro.Text != "" && txtCurrentTL.Text != "") {
                txtResultTL.Text = (Convert.ToDouble(txtCurrentTL.Text) / Convert.ToDouble(txtKurEuro.Text)).ToString();
            }
        }

        private void txtKurSterlin_TextChanged(object sender, EventArgs e) {
            if (txtKurSterlin.Text != "" && txtCurrentTL.Text != "") {
                txtResultTL.Text = (Convert.ToDouble(txtCurrentTL.Text) / Convert.ToDouble(txtKurSterlin.Text)).ToString();
            }
        }
    }
}
