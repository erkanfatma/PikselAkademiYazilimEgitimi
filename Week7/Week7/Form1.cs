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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] sayilar = { 3, 87, 3, 5, 87, 9, 2, 3 };

            int[] sonuc = new int[2];
             
            sonuc[0] = sayilar[sayilar.Length / 2];
            sonuc[1] = sayilar[sayilar.Length / 2 + 1];
        }
    }
}
