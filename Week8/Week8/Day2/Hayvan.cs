using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8.Day2
{
    public class Hayvan
    {
        public string Adi;
        public byte AyakSayisi;
        public string Rengi;
        public string Cinsi;
        public bool KanatliMi;
        public byte IQ;
        public bool KuyrukluMu;
        public byte Hizi;

        public string SesCikar()
        {
            return "Ses";
        }

        public int Kos()
        {
            return Hizi + 5;
        }
    }
}
