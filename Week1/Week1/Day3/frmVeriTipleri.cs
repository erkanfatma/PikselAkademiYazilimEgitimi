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
    public partial class frmVeriTipleri : Form {
        public frmVeriTipleri() {
            InitializeComponent();
            //1. form
        }

        private void frmVeriTipleri_Load(object sender, EventArgs e) {
            #region Data Types

            //Data Types 
            #region Value Types
            //Value Types
            bool isActive = true;
            byte age = 20;
            sbyte temp = -127;
            ushort number = 65535;
            short productNumber = 12345;
            int productCount = 2134533;
            long personCount = 213324343423213;
            #endregion

            #region Floating Types
            //FLoating Types 
            float floatSayi = 1123.12f;
            double doubleSayi = 12.12d;
            decimal decimalSayi = 12.12m;
            #endregion

            #region Reference Types
            //Reference Types 
            char tekKarakter = 'f';
            string cokKarakter = "Fatma Erkan";
            #endregion

            #endregion
        }
    }
}
