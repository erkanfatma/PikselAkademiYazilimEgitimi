using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4.Day1
{
    public partial class frmTekCift : Form
    {
        public frmTekCift()
        {
            InitializeComponent();
        }

        private void frmTekCift_Load(object sender, EventArgs e)
        {
            int[] sayilar = { 1, 3, 5, 2, 65, 83, 68, 3, 7, 9, 2, 365, 0 };
            int tekSayac = 0;
            int ciftSayac = 0;
            for (int i = 0; i <= sayilar.Length -1; i++)
            {
                if (sayilar[i] % 2 == 0)
                {
                    ciftSayac++;
                }
                else
                {
                    tekSayac++;
                }
            }
            MessageBox.Show("Tek sayılar : " + tekSayac.ToString() 
                + " Çift sayılar : " + ciftSayac.ToString());
        }
    }
}
