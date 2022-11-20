using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tekrar.Hafta4
{
    public partial class frmSoru16 : Form
    {
        public frmSoru16()
        {
            InitializeComponent();
        }

        private void frmSoru16_Load(object sender, EventArgs e)
        {
            
        }

        public List<int> SifirlariSonaEkle(List<int> sayilar)
        {
            List<int> sonuc = new List<int>();
            int sayac = 0;
            for (int i = 0; i < sayilar.Count; i++)
            {
                if (sayilar[i] != 0)
                {
                    sonuc.Add(sayilar[i]);
                }
                else
                {
                    sayac++;
                }
            }

            for (int i = 0; i < sayac; i++)
            {
                sonuc.Add(0);
            }
            return sonuc;
        }
    }
}
