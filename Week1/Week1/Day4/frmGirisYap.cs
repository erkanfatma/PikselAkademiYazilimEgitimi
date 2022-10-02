using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week1.Day4 {
    public partial class frmGirisYap : Form {
        public frmGirisYap() {
            InitializeComponent();
            //3. form
        }

        private void btnGirisYap_Click(object sender, EventArgs e) {
            string name = txtKullaniciAdi.Text;
            string pass = txtSifre.Text;
            if (name == "fatma" && pass == "123") {
                MessageBox.Show("Giriş başarılı.");
            }
            else {
                MessageBox.Show("Bilgilerinizi kontrol edin.");
            }

        }
    }
}
