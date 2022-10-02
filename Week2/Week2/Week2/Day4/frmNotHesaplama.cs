using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week2.Day4 {
    public partial class frmNotHesaplama : Form {
        public frmNotHesaplama() {
            InitializeComponent();
            //1. form
        }

        private void btnHesapla_Click(object sender, EventArgs e) {
            try {
                string name = txtIsim.Text;
                int vize = Convert.ToInt32(txtVize.Text);
                int final = Convert.ToInt32(txtFinal.Text);

                int not = vize * 40 / 100 + final * 60 / 100;

                if (not >= 60 && final >= 35) {
                    lstGecenler.Items.Add(name);
                }
                else {
                    lstKalanlar.Items.Add(name);
                }

            }
            catch (Exception) {
                MessageBox.Show("Girdiğiniz değerleri kontrol edin.");
            }


        }
    }
}
