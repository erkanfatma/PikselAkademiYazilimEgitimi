using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homeworks
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            int[] sayilar = { 2,3,4,10,4,6,20, 2, 30};
            List<int> sonuc = new List<int>();
            int sayac = 0;
            for (int i = 0; i < sayilar.Length; i++) {
                if (sayilar[i] % 10 == 0) {
                    sayac = sayilar[i];
                }

                if (sayac == 0) {
                    sonuc.Add(sayilar[i]);
                }
                else {
                    sonuc.Add(sayac);
                }

            }
        }
    }
}
