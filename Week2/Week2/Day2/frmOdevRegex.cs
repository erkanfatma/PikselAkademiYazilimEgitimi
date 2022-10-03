using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Week2.Day2 {
    public partial class frmOdevRegex : Form {
        public frmOdevRegex() {
            InitializeComponent();
            //5. form
        }

        private void frmOdevRegex_Load(object sender, EventArgs e) {
            lblEmailDogrulama.Text = "";
            lblSifreDogrulama.Text = "";
        }

        private void btnGirisYap_Click(object sender, EventArgs e) {
            Regex emailRegex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            Regex sifreRegex = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");

            string email = txtEmail.Text;
            string sifre = txtSifre.Text;

            if (!emailRegex.IsMatch(email)) {
                lblEmailDogrulama.Text = "Geçerli bir email adresi girin.";
            }
            if (!sifreRegex.IsMatch(sifre)) {
                lblEmailDogrulama.Text = "Geçerli bir şifre girin.";
            }

            if (emailRegex.IsMatch(email) && sifreRegex.IsMatch(sifre)) {
                if (email == "info@pikselakademi.com" && sifre == "Wf35!e5&") {
                    MessageBox.Show("Hoş geldiniz!");
                }
                else {
                    MessageBox.Show("Bilgilerinizin doğruluğunu kontrol edin");
                }
            }

            txtEmail.Text = "";
            txtSifre.Text = "";

        }
    }
}
