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
    public partial class frmGunler : Form {
        public frmGunler() {
            InitializeComponent();
        }

        private void btnKontrolEt_Click(object sender, EventArgs e) {
            string gun = txtGun.Text.ToLower();
            switch (gun) {
                case "pazartesi":
                case "salı":
                case "çarşamba":
                case "perşembe":
                case "cuma":
                    lstHaftaici.Items.Add(gun);
                    break;
                case "cumartesi":
                case "pazar":
                    lstHaftasonu.Items.Add(gun);
                    break;
                default:
                    MessageBox.Show("Yanlış değer girdiniz");
                    break;
            }
        }
    }
}
