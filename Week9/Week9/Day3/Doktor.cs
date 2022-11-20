using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders3
{
    public class Doktor : Calisan
    {
        public string Uzmanligi { get; set; }

        public Doktor(int kati, int zamkatiorani)
        {
            Maasi = Maasi * kati;
            ZamOrani = ZamOrani * zamkatiorani;
        }
    }
}
