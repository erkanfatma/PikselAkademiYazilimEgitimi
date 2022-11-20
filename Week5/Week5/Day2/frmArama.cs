using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week5.Day2
{
    public partial class frmArama : Form
    {
        public frmArama()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sayi = Convert.ToInt32(textBox1.Text);
            if (SayiVarMi(sayilar, sayi)) {
                MessageBox.Show("Sayı var");
            }
            else {
                MessageBox.Show("Sayı yok");
            }
        }

        public bool SayiVarMi(int[] dizi, int sayi) {
            for (int i = 0; i < dizi.Length; i++) {
                if (dizi[i] == sayi) {
                    return true;
                }
            }
            return false;
        }
    }
}
