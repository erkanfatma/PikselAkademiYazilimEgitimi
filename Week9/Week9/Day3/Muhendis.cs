using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders3
{
    public class Muhendis : Calisan
    {
        public string GelistirmeAlani { get; set; }

        public Muhendis()
        {
            Maasi = Maasi * 3;
        }
    }
}
