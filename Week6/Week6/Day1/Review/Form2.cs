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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        List<string> meyveler = new List<string>() {
                "Nar", "Erik", "Domates", "Muz", "Çilek", "Kivi"
            };
        private void Form2_Load(object sender, EventArgs e)
        {
           

            SevdigimMeyveBurdaMi(meyveler, "Çilek");

        }


        public bool SevdigimMeyveBurdaMi(List<string> meyveListesi, string sevdigimMeyve)
        {
            foreach (var meyve in meyveListesi)
            {
                if (meyve == sevdigimMeyve)
                {
                    return true;
                }
            }
            return false;
        }


        public int BuyukSayilarinToplami(List<int> sayiListesi, int gelenSayi)
        {
            int toplam = 0;
            for (int i = 0; i < sayiListesi.Count; i++)
            {
                if (sayiListesi[i] > gelenSayi)
                {
                    toplam += sayiListesi[i];
                }
            }

            return toplam;
        }

        public List<int> KucukOlanSayilariListele(List<int> sayilistesi, int gelensayi)
        {
            List<int> sonuc = new List<int>();

            for (int i = 0; i < sayilistesi.Count; i++)
            {
                if (gelensayi > sayilistesi[i])
                {
                    sonuc.Add(sayilistesi[i]);
                }
            }
            return sonuc;
        }


        public bool TekSayilarinToplamiBuyukMu(List<int> sayilar)
        {
            int teklerToplami = 0;
            int ciftlerToplami = 0;

            for (int i = 0; i < sayilar.Count; i++) {
                if (sayilar[i] % 2 == 0) {
                    ciftlerToplami += sayilar[i];
                }
                else {
                    teklerToplami += sayilar[i];
                }
            } 
            if (ciftlerToplami > teklerToplami) {
                return false;
            }
            return true;
        }
    }
}
