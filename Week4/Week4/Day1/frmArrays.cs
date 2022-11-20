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
    public partial class frmArrays : Form
    {
        public frmArrays()
        {
            InitializeComponent();
            //1. form tekrar
        }

        private void frmArrays_Load(object sender, EventArgs e)
        {
            // sayı dizisi 
            int[] sayilar = new int[10]; // 10 = dizinin uzunluğu
            sayilar[0] = 1;
            //sayı dizisi 2
            int[] sayilar2 = { 1, 2, 3, 45 };
            //özellikler
            //uzunluğu
            int n = sayilar.Length;
            sayilar.Count();

            sayilar.Sum(); //toplamı
            sayilar.Average(); //ortalaması
            //yeniden boyutlandırma
            Array.Resize(ref sayilar, 20);

            //string split 
            string name = "Fatma-Erkan";
            name.Split('-');
        }
    }
}
