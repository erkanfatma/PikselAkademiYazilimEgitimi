using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week2.Day2 {
    public partial class frmHaftaIciHaftaSonu : Form {
        public frmHaftaIciHaftaSonu() {
            InitializeComponent();
            //3. form
        }

        private void btnKontrolEt_Click(object sender, EventArgs e) {
            string gun = txtGun.Text;
            switch (gun) {
                case "Pazartesi":
                case "Salı":
                case "Çarşamba":
                case "Perşembe":
                case "Cuma":
                    MessageBox.Show("Hafta içi");
                    break;
                case "Cumartesi":
                case "Pazar":
                    MessageBox.Show("Hafta sonu");
                    break;

                default:
                    break;
            }
        }
    }
}
