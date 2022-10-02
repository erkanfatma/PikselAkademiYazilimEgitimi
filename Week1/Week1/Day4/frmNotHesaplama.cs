using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week1.Day4 {
    public partial class frmNotHesaplama : Form {
        public frmNotHesaplama() {
            InitializeComponent();
            //2. Form
        }

        private void btnKontrolEt_Click(object sender, EventArgs e) {
            int not = Convert.ToInt32(txtNot.Text);
            if (not <= 50 && not >= 35) {
                lblSonuc.Text = "DD";
            }
            else if (not < 35) {
                lblSonuc.Text = "FF";
            }

            else if (not < 90 && not > 60) {
                lblSonuc.Text = "DC";
            }
            else {
                lblSonuc.Text = "AA";
            }
        }
    }
}
