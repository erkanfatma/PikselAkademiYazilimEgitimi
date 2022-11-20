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
    public partial class frmSansliArray : Form
    {
        public frmSansliArray()
        {
            InitializeComponent();
        }

        private void frmSansliArray_Load(object sender, EventArgs e)
        {
            int[] sayilar = {1,3,56,678,435,67,84,57,45 };
            int counter = 0;
            foreach (var item in sayilar)
            {
                //sayilar[i]
                if (item == 1 || item == 3)
                {
                    counter++;
                } 
            }

            if (counter == 0)
            {
                MessageBox.Show("Şanslı array");
            }
            else
            {
                MessageBox.Show("Şanssız array");
            }
        }
    }
}
