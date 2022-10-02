using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week1.Day2 {
    public partial class frmHosgeldiniz : Form {
        public frmHosgeldiniz() {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            string name = txtName.Text;
            MessageBox.Show(name);
        }
    }
}
