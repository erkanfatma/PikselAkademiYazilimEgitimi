using System;
using System.Collections;
using System.Windows.Forms;

namespace Week5
{
    public partial class frmArrayList : Form
    {
        public frmArrayList()
        {
            InitializeComponent();
        }

        private void frmArrayList_Load(object sender, EventArgs e)
        {
            //tanımlama
           ArrayList bilgilerim = new ArrayList();
            bilgilerim.Add("Fatma");
            bilgilerim.Add(12);
            bilgilerim.Add(23.5);
            bilgilerim.Add(true);


            ArrayList bilgilerim2 = new ArrayList()
            { "Fatma" , 1, 23.5, true};

            //veriye ulaşma
            string name = bilgilerim[0].ToString();

            //silme
            bilgilerim.RemoveAt(0);

            //değiştirme
            bilgilerim[1] = 20;

            //kontrol etme
            bilgilerim.Contains("Fatma");

            //uzunluğu
            int uzunlugu = bilgilerim.Count;
        }
    }
}
