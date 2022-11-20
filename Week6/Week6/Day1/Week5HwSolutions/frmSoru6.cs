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
    public partial class frmSoru6 : Form
    {
        public frmSoru6()
        {
            InitializeComponent();
        }

        private void frmSoru6_Load(object sender, EventArgs e)
        {

        }

        public int KarakterSayisi(string metin)
        {
            string[] metinListesi = metin.Split(' ');

            string sonkelime = metinListesi[metinListesi.Length - 1];
            return sonkelime.Length;
             
        }
    }
}
