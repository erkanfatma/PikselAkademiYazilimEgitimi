using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week1.Day3 {
    public partial class frmOdevBilgilerim : Form {
        public frmOdevBilgilerim() {
            InitializeComponent();
            //3. form
        }

        private void btnPrint_Click(object sender, EventArgs e) {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            byte age = Convert.ToByte(txtAge.Text);

            lblOutput.Text = firstName + " " + lastName + " " + age;
        }
    }
}
