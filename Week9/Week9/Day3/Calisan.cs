using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders3
{
    public class Calisan  {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public byte Yasi { get; set; }
        public double Maasi = 5500.0;
        public int ZamOrani = 2;
        public string BaslangicTarihi { get; set; }
        public byte GunlukCalismaSaati { get; set; } 
        public void ZamYap() {
            Maasi = Maasi * ZamOrani;
        }
    }
}
