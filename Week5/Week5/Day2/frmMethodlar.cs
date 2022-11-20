using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week5.Day2
{
    public partial class frmMethodlar : Form
    {
        public frmMethodlar()
        {
            InitializeComponent();
        }

        private void frmMethodlar_Load(object sender, EventArgs e)
        {
           
        }

        public int Topla(int a, int b) {
            return a+ b;
        } 
        private void btnTopla_Click(object sender, EventArgs e)  {
            int sayi1 = Convert.ToInt32(txtsayi1.Text);
            int sayi2 = Convert.ToInt32(txtsayi2.Text);
            int sonuc = Topla(sayi1, sayi2);
        } 
        public void HosgeldinYazdir(string name)  {
            MessageBox.Show("Hoş geldin " + name);
        } 
        private void btnYazdir_Click(object sender, EventArgs e)  {
            HosgeldinYazdir(txtName.Text); 
        }

      
    }
}
