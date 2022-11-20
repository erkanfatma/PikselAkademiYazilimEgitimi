using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8.Day4
{
    public class Araba
    {
        //attributes 
        public string renk;
        public byte kapisayisi;
        public string marka;
        public string model;
        public double motorgucu;

        //methods
        public int hizlan(int hiz)
        {
            return hiz + 10;
        }
        public int fren(int hiz)
        {
            return hiz - 10;
        }
        public void sescikar()
        {
            Console.WriteLine("bip");
        }


    }
}
