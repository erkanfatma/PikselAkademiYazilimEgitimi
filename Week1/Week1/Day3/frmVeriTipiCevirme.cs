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
    public partial class frmVeriTipiCevirme : Form {
        public frmVeriTipiCevirme() {
            InitializeComponent();
            //2. form
        }
        private void btnSum_Click(object sender, EventArgs e) {
            //8 byte
            //int number1 = Convert.ToInt32(txtNumber1.Text);
            //int number2 = Convert.ToInt32(txtNumber2.Text);

            //int result = number1 + number2;

            lblResult.Text = (Convert.ToInt32(txtNumber1.Text) +
               Convert.ToInt32(txtNumber2.Text)).ToString();
        }

        private void btnBol_Click(object sender, EventArgs e) {
            //double number1 = Convert.ToDouble(txtNumber1.Text);
            //double number2 = Convert.ToDouble(txtNumber2.Text);

            //double result = number1 / number2;

            //lblResult.Text = result.ToString();

            lblResult.Text = (Convert.ToDouble(txtNumber1.Text) /
              Convert.ToDouble(txtNumber2.Text)).ToString();
        }

        private void btnCikar_Click(object sender, EventArgs e) {
            //int number1 = Convert.ToInt32(txtNumber1.Text);
            //int number2 = Convert.ToInt32(txtNumber2.Text);

            //int result = number1 - number2;

            //lblResult.Text = result.ToString();
            lblResult.Text = (Convert.ToInt32(txtNumber1.Text) -
              Convert.ToInt32(txtNumber2.Text)).ToString();
        }

        private void btnCarp_Click(object sender, EventArgs e) {
            //int number1 = Convert.ToInt32(txtNumber1.Text);
            //int number2 = Convert.ToInt32(txtNumber2.Text);

            //int result = number1 * number2;

            //lblResult.Text = result.ToString();
            lblResult.Text = (Convert.ToInt32(txtNumber1.Text) *
              Convert.ToInt32(txtNumber2.Text)).ToString();
        }

    }
}
