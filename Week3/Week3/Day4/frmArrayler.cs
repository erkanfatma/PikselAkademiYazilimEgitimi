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
    public partial class frmArrayler : Form {
        public frmArrayler() {
            InitializeComponent();
            //4. form
        }

        private void frmArrayler_Load(object sender, EventArgs e) {
            int[] sayilar = new int[3]; //3 = array uzunluğu
            sayilar[0] = 1; //1. elemanın atanması
            sayilar[1] = 2; //2. elemanın atanması
            sayilar[2] = 3; //3. elemanın atanması

            int[] sayilar2 = { 1, 2, 3, 4, 5 };
            int secilensayi = sayilar2[0]; //1. elemana ulaşmak için


            string[] ogrenciler = new string[10];
            ogrenciler[0] = "Nisa";
            ogrenciler[1] = "Zeynep";
            ogrenciler[2] = "Poyraz";

            MessageBox.Show(ogrenciler[2]); // çıktısı = Poyraz

            ogrenciler[2] = "Efe";
            MessageBox.Show(ogrenciler[2]);

            //array boyutu
            int n = sayilar.Length;
            sayilar.Count();


            sayilar.Sum(); //arraydeki değerlerin toplamı
            sayilar.Average(); //arraydeki değerlerin ortalaması

        }
    }
}
