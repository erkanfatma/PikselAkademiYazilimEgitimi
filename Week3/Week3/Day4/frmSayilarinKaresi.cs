using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week3.Day4 {
    public partial class frmSayilarinKaresi : Form {
        public frmSayilarinKaresi() {
            InitializeComponent();
            //3. form
        }

        private void btnHesapla_Click(object sender, EventArgs e) {
            int sayi = Convert.ToInt32(txtSayi.Text);

            for (int i = 1; i < sayi; i++) {
                // 5'e bölünebilen sayıları yazmasın
                if (i % 5 != 0) {
                    lstKareleri.Items.Add(i.ToString() + " - " + (i * i).ToString());
                    lstKareleri.Items.Add(i.ToString() + " - " + (i * i * i).ToString());
                }
                
            }
        }
    }
}
