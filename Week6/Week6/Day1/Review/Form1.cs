using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tekrar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                MessageBox.Show(i.ToString());
            }

            List<int> sayilar = new List<int>() { 1,5,9,3,2,0 };
            foreach (int sayi in sayilar)
            {
                MessageBox.Show(sayi.ToString());
            }
            
            //int sonuc = AradakiSayilariTopla(20, 80);
            SonucGoster(AradakiSayilariTopla(20, 80));
        }

        public int AradakiSayilariTopla(int baslangic, int bitis)
        {
            int toplam = 0;
            for (int i = baslangic; i < bitis; i++)
            {
                toplam += i;
            }
            return toplam;
        }

        public void SonucGoster(int sonuc)
        {
            MessageBox.Show(sonuc.ToString());
        }

        public bool SayiAraliktaMi(int baslangic, int bitis, int sayi)
        {
            if (baslangic < sayi && sayi < bitis)
            {
                return true;
            }
            else
            {
                return false;
            }
            //for (int i = baslangic; i < bitis; i++)
            //{
            //    if (i == sayi)
            //    {
            //        return true;
            //    }
            //}
            //return false;
        }
    }
}
