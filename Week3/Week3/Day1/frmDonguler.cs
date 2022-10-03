using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week3.Day1 {
    public partial class frmDonguler : Form {
        public frmDonguler() {
            InitializeComponent();
            //1. form 
        }

        private void frmDonguler_Load(object sender, EventArgs e) {
            /*
             1. For
            2. While
            3. Foreach
            4. do-while*/
        }

        private void btnYazdir_Click(object sender, EventArgs e) {
            //1. For Loop
            for (int i = 0; i < 10; i++) {
             //   lstSayilar.Items.Add(i);
            }

            //2. While Loop
            int j = 1;
            while (j< 100) {
                //lstSayilar.Items.Add(j);
                j++;
            }

            //3. Do-while Loop
            int k = 0;
            do {
                lstSayilar.Items.Add(k);
                k++;
            } while (k < -5);
            MessageBox.Show(k.ToString());
        }
    }
}
