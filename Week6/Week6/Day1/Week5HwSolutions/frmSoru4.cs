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
    public partial class frmSoru4 : Form
    {
        public frmSoru4()
        {
            InitializeComponent();
        }

        private void frmSoru4_Load(object sender, EventArgs e)
        {

        }

        List<string> Silinmeyenler(List<string> metinler, string silinecek)
        {
            List<string> sonucListesi = new List<string>();
            for (int i = 0; i < metinler.Count; i++)
            {
                if (metinler[i] != silinecek)
                {
                    sonucListesi.Add(metinler[i]);
                }
            }

            return sonucListesi;
        }
    }
}
