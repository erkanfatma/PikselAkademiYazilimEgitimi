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
    public partial class frmKardesArray : Form
    {
        public frmKardesArray()
        {
            InitializeComponent();
            //3. 
        }

        private void frmKardesArray_Load(object sender, EventArgs e)
        {
            int[] sayilar = { 1, 2, 3, 4, 5, 76, 8 };
            int[] sayilar2 = { 1, 3, 45, 6, 7, 8, 8 };

            if (sayilar[0] == sayilar2[0] 
                && sayilar[sayilar.Length - 1] == sayilar2[sayilar2.Length - 1])
            {
                MessageBox.Show("Kardeş arrayler");
            }
        }
    }
}
