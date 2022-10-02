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
    public partial class frmSartlar : Form {
        public frmSartlar() {
            InitializeComponent();
            //1. form
        }

        private void frmSartlar_Load(object sender, EventArgs e) {
            //mantıksal operatörler
            // ==  eşit 
            // != eşit değilse
            // && ve 
            // || veya 
            // > , < , <= , >=


            //aritmetik operatörler
            // -= 
            // +=
            // /=
            // *= 
            // %
            // ++
            // --
        }

        int sayi; // global variable
        private void btnIslem_Click(object sender, EventArgs e) {
            //int sayi = Convert.ToInt32(txtNumber.Text); // local variable
            //sayi = Convert.ToInt32(txtNumber.Text);

            sayi++;
             
            lblSonuc.Text = sayi.ToString();
        }

        private void btnMesajYazdir_Click(object sender, EventArgs e) {
            string name = txtIsim.Text;
            if (name == "fatma") {
                MessageBox.Show("Hoş geldin Fatma");
            }
            else {
                MessageBox.Show("Hoş geldin");
            }
        }

        private void txtNumber_TextChanged(object sender, EventArgs e) {
            try {
                sayi = Convert.ToInt32(txtNumber.Text);
            }
            catch (Exception) {
                MessageBox.Show("Lütfen sayı girin.");
            }
        }
    }
}
