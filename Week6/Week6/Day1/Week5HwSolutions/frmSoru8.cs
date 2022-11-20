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
    public partial class frmSoru8 : Form
    {
        public frmSoru8()
        {
            InitializeComponent();
        }

        private void frmSoru8_Load(object sender, EventArgs e)
        {
            List<int> sayiListesi = new List<int> { 2, 1, 3, 2, 1 };
            
            int tekOlanSayi = BirKereOlanSayi(sayiListesi);

            if (tekOlanSayi == -1)
            {
                MessageBox.Show("Tek olan sayı yok");
            }
            else
            {
                MessageBox.Show("Tek olan sayı:" + tekOlanSayi.ToString()); ;
            }
        }

        public int BirKereOlanSayi(List<int> sayilar)
        {
            int sayac = 0;
            for (int i = 0; i < sayilar.Count; i++) { 
                for (int j = 0; j < sayilar.Count; j++) {
                    if (sayilar[i] == sayilar[j]) {
                        sayac++;
                    }
                }
                if (sayac < 2) {
                    return sayilar[i];
                } 
                sayac = 0;
            }
            return -1; //hiçbiri yoksa
        }
    }
}
