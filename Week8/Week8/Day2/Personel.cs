using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8.Day2
{
    public class Personel
    {
        //attributes
        public string Ad;
        public string Soyisim;
        public byte Yas;
        public byte Boy;
        public byte Kilo;
        public bool ErkekMi;
        public double Maas;
        public byte IzinGunu;
        public int CalismaSaati;

        //methods
        public int hareket()
        {
            return 0;
        }

        public int mesai()
        {
            return CalismaSaati + 1;
        }
    }
}
