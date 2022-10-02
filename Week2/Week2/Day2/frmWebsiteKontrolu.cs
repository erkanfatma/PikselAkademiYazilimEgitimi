using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week2.Day2 {
    public partial class frmWebsiteKontrolu : Form {
        public frmWebsiteKontrolu() {
            InitializeComponent();
            //5. form
        }

        private void btnKontrolEt_Click(object sender, EventArgs e) {
            string name = txtMetin.Text;

            // url : http ya da https ya da www ile başlaması gerekiyor 
            // .com ya da .net ile bitmesi gerekiyor

            if ((name.StartsWith("http://") || name.StartsWith("https://") || name.StartsWith("www")) && (name.EndsWith(".com") || name.EndsWith(".net"))) {
                MessageBox.Show("Geçerli site adı");
            }
            else {
                MessageBox.Show("Geçersiz site adı");
            }

            lblMetin.Text = name.Length.ToString();
        }
    }
}
