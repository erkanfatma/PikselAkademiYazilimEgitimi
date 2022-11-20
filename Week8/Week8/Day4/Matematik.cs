using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8.Day4
{
    public class Matematik
    {
        //attributes 
        public readonly int pi = 3;
        public List<int> sayilar = new List<int>();

        //methods
        public int Toplama(int a, int b)
        {
            return a + b;
        }
        public int Cikarma(int a, int b)
        {
            return a - b;
        }
        public int Carpma(int a, int b)
        {
            return a * b;
        }
        public int Bolme(int a, int b)
        {
            return a / b;
        }
    }
}
