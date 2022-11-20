using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {


            int[] myArray = { 1, 4, 5, 4, 6, 9, 3, 2, 10, 9 };
            myArray[2] = 4;
            myArray[1] = myArray[2] + myArray[3];
            myArray[0] = 1;
            myArray[3] = 7;
            myArray[5] = myArray[0];
            myArray[4] = myArray[1] + myArray[0];
            myArray[9] = myArray[4] + myArray[1];
            myArray[1] = myArray[3];



            string isminiz = "" ;// "Buraya kendi isminizi yazın"
            string sonuc = "";

            for (int i = 0; i < isminiz.Length; i++) {
                sonuc += "Hello - ";
            }

            MessageBox.Show(sonuc);




            for (int i = 3; i <= 12; i++) {
                sonuc += i.ToString() + " ";
            }
            MessageBox.Show(sonuc);



        }
    }
}
