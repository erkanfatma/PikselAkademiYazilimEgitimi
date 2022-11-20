using System;
using System.Collections;
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
    public partial class frmHashTable : Form
    {
        public frmHashTable()
        {
            InitializeComponent();
        }
        Hashtable ht = new Hashtable();
        private void frmHashTable_Load(object sender, EventArgs e)
        {
            
            ht.Add("isim", "Fatma");
            ht.Add(2, "Erkan");
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            ht.Add("isim", txtIsim.Text);
        }
    }
}
