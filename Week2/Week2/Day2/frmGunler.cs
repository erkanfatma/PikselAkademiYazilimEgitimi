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
    public partial class frmGunler : Form {
        public frmGunler() {
            InitializeComponent();
            //1. form
        }

        private void btnKontrolEt_Click(object sender, EventArgs e) {
            int deger = Convert.ToInt32(txtDeger.Text);
            switch (deger) {
                case 1:
                    //işlem yap
                    MessageBox.Show("Pazartesi");
                    break;
                case 2:
                    MessageBox.Show("Salı");
                    break;
                case 3:
                    MessageBox.Show("Çarşamba");
                    break;
                case 4:
                    MessageBox.Show("Perşembe");
                    break;
                case 5:
                    MessageBox.Show("Cuma");
                    break;
                case 6:
                    MessageBox.Show("Cumartesi");
                    break;
                case 7:
                    MessageBox.Show("Pazar");
                    break;
                default:
                    MessageBox.Show("Yanlış değer girdiniz");
                    break;
            }
        }
    }
}
