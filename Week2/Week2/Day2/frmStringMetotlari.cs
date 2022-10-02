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
    public partial class frmStringMetotlari : Form {
        public frmStringMetotlari() {
            InitializeComponent();
            //4. form
        }

        private void btnKontrolEt_Click(object sender, EventArgs e) {
            string metin = txtMetin.Text;


            //if (metin.Contains("a")) {
            //    MessageBox.Show("A harfini içeriyor");
            //}
            //if (metin.ToLower().StartsWith("a".ToLower())) {
            //    MessageBox.Show("A harfi ile başlıyor");
            //}

            //lblBoyutu.Text = metin.Length.ToString();

            //if (metin.Length == 6) {
            //    MessageBox.Show("Bu metin 6 karakterli");
            //}

            lblBoyutu.BackColor = Color.Red;
            lblRenk.BackColor = Color.Green;

            string yenimetin = metin.Replace("ı", "i");
            lblBoyutu.Text = yenimetin;

            string yenimetin2 = metin.Trim();
            lblBoyutu.Text = yenimetin2;

            string yenimetin3 = metin.TrimEnd();
            string yenimetin4 = metin.TrimStart();

            metin.ToUpper();
            metin.ToLower();
        }
    }
}
