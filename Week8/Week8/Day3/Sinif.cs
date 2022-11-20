using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta9Ders3
{
    class Sinif
    {
        private byte OgrenciSayisi { get; set; }
        public string Adi { get; set; }
        public string EgitmenAdi { get; set; }
        public byte MasaSayisi { get; set; }
        public byte BilgisayarSayisi { get; set; }
        public int DersSayisi { get; set; }


        public int DersIsle()
        {
            return DersSayisi + 1;
        }
    }
}
