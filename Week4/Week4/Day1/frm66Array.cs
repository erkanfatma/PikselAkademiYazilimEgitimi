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
    public partial class frm66Array : Form
    {
        public frm66Array()
        {
            InitializeComponent();
            //2. form
        }

        private void frm66Array_Load(object sender, EventArgs e)
        {

        }

        private void btnKontrolEt_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 1, 2, 3, 4, 5, 6 };

            if (sayilar[0] == 6 && sayilar[5] == 6)
            {
                lstArrays.Items.Add("sayilar");
            }

            int[] sayilar2 = { 6, 2, 5, 7, 3, 7, 9, 6 };
            if (sayilar2[0] == 6 && sayilar2[sayilar2.Length - 1] == 6)
            {
                lstArrays.Items.Add("sayilar2");
            }
        }
    }
}
