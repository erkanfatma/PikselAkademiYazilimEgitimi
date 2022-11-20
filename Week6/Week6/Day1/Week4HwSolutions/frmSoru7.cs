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
    public partial class frmSoru7 : Form
    {
        public frmSoru7()
        {
            InitializeComponent();
        }

        private void frmSoru7_Load(object sender, EventArgs e)
        {
            /*
             String parametresi alan bir metot tanımlayın. Metnin içerisindeki
harflerden kaçar tane olduğunu string listesine "X-3" şeklinde yazdırın.
String listesi olarak geri döndürsün.
Örn: akademi
liste = "a - 2", "k - 1", "d - 1", "e - 1", "m -1", "i -1"*/

            
        }

        public List<string> karaktersayisinihesapla(string metin)
        {
            List<string> sonuc = new List<string>();
            string[] harfler = metin.Split();

            for (int i = 0; i < harfler.Length; i++) {
                int sayac = 0;
                for (int j = 0; j < harfler.Length; j++) {
                    if (harfler[i] == harfler[j]) {
                        sayac++;
                    }
                }
                //o listede var mı
                int sayac2 = 0; 
                for (int k = 0; k < sonuc.Count; k++) {
                    if (sonuc[k].Contains(harfler[i])) { 
                        sayac2++;
                    }
                }
                if (sayac2 == 0 ) {
                    sonuc.Add(harfler[i] + "-" + sayac.ToString());
                } 
                
            }

            return sonuc;
        }
    }
}
