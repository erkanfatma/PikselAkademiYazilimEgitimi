using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week3.Day3 {
    public partial class frmTekrar : Form {
        public frmTekrar() {
            InitializeComponent();
            //1. form
        }

        private void frmTekrar_Load(object sender, EventArgs e) {

            for (int i = 1; i < 100; i++) {
                MessageBox.Show("Ödevlerimi neden yapmadım");
            }

        }
    }
}
