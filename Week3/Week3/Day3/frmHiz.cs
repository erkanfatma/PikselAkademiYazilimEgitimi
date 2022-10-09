using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week3.Day3 {
    public partial class frmHiz : Form {
        public frmHiz() {
            InitializeComponent();
            //2. form
        }

        private void btnHesapla_Click(object sender, EventArgs e) {
            int baslangicHiz = Convert.ToInt32(txtHiz.Text);

            for (int i = baslangicHiz; i >= 0; i -= 10) {
                if (i <= 200 && i >= 100) {
                    lstHiz.Items.Add(i.ToString() + " Çok hızlısın yavaşla");
                }
                else if (i < 100 && i>= 70) {
                    lstHiz.Items.Add(i.ToString() + " Yavaşla");
                }
                else if(i < 70 && i>= 50) {
                    lstHiz.Items.Add(i.ToString() + " Normal");
                }
                else if (i < 50 && i>= 10) {
                    lstHiz.Items.Add(i.ToString() + " Durmak üzeresin");
                }else if(i<10 && i>= 0) {
                    lstHiz.Items.Add(i.ToString() + " Durdun");
                }
                else {
                    lstHiz.Items.Add(i.ToString() + " Geçersiz hız");
                }

            }
        }
    }
}
