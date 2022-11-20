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
    public partial class frmForeach : Form
    {
        public frmForeach()
        {
            InitializeComponent();
        }

        private void frmForeach_Load(object sender, EventArgs e)
        {
            string[] names = { "Efe", "Poyraz", "Zeynep", "Nisa" };
            foreach (var item in names)
            {
                lstIsimler.Items.Add(item);
            }
        }
    }
}
