using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week5
{
    public partial class frmGeneric : Form
    {
        public frmGeneric()
        {
            InitializeComponent();
        }

        private void frmGeneric_Load(object sender, EventArgs e)
        {
            List<string> sinifListesi = new List<string>();
            sinifListesi.Add("Alper");
            sinifListesi.Add("Yalın");

            sinifListesi.Clear();

            sinifListesi.RemoveAt(0);

            sinifListesi.Count();


        }
    }
}
