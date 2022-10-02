using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week1.WeekendHomeworks {
    public partial class frmTekCift : Form {
        public frmTekCift() {
            InitializeComponent();
            //1. form 
        }

        private void btnSonuc_Click(object sender, EventArgs e) {
            try {
                int sayi = Convert.ToInt32(txtSayi.Text);
                if (sayi % 2 == 0) {
                    lblSonuc.Text = "Çift";
                }
                else {
                    lblSonuc.Text = "Tek";
                }
            }
            catch (Exception) {

                MessageBox.Show("Lütfen geçerli bir değer girin.");
            }
          
        }
    }
}
