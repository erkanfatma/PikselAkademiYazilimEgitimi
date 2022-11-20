using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week5
{
    public partial class frmStackAndQueue : Form
    {
        public frmStackAndQueue()
        {
            InitializeComponent();
        }

        private void frmStackAndQueue_Load(object sender, EventArgs e)
        {
            Stack stack = new Stack();
            stack.Push("fatma");
            stack.Push("ONUR");
            stack.Push("zeynep");

            stack.Pop();

            Queue queue = new Queue();
            queue.Enqueue("erkan");
            queue.Dequeue();
        }
    }
}
