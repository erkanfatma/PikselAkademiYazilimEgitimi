using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tekrar.Hafta5
{
    public partial class frmSoru18 : Form
    {
        public frmSoru18()
        {
            InitializeComponent();
        }

        private void frmSoru18_Load(object sender, EventArgs e)
        {

        }

        public int BuyukKarakterleriSay(string metin)
        {
            string buyukHarfler = "ABCDEFGĞHIİJKLMNOPRSŞTUÜVYZXQW";
            string[] metinHarfleri = metin.Split(' ');
            int sayac = 0;
            for (int i = 0; i < metinHarfleri.Length; i++)
            {
                if (buyukHarfler.Contains(metinHarfleri[i]))
                {
                    sayac++;
                }
            }
            return sayac;
        }
    }
}
