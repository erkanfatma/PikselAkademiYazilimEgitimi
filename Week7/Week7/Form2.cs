using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homeworks
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string[] A = { "x", "z", "a", "t" };
            string[] B = { "a", "r", "y", "m" };
            List<string> C = new List<string>();

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    if (A[i].ToLower() == B[j].ToLower())
                    {
                        C.Add(A[i]);
                        //C.Add(B[j]);
                    }
                }
            }
        }
    }
}
