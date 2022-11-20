namespace Week8.Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Personel
            /*
            Personel emir = new Personel();
            emir.Ad = "Emir";
            emir.Soyisim = "Çelik";
            emir.Boy = 190;
            emir.ErkekMi = true;
            emir.IzinGunu = 10;
            emir.Maas = 30.000;
            emir.CalismaSaati = 5;
            emir.Kilo = 30;
            emir.Yas = 20;

            Personel nisa = new Personel();
            nisa.Ad = "Nisa";
            nisa.Soyisim = "Topal";
            nisa.Boy = 200;
            nisa.ErkekMi = false;
            nisa.IzinGunu = 20;
            nisa.Maas = 30.000;
            nisa.CalismaSaati = 8;
            nisa.Kilo = 30;
            nisa.Yas = 19;

            Console.WriteLine("AD SOYAD: " + nisa.Ad + " " + nisa.Soyisim);
            Console.WriteLine("BOY: " + nisa.Boy + " KİLO" + nisa.Kilo);
            Console.WriteLine("YAS: " + nisa.Yas);
            //if (nisa.ErkekMi)
            //{
            //    Console.WriteLine("CİNSİYET: ERKEK" );
            //}
            //else
            //{
            //    Console.WriteLine("CİNSİYET: KIZ"); 
            //}

            //kontrol ifadesi ? true : false
            Console.WriteLine("CİNSİYET" + (nisa.ErkekMi ? "ERKEK" : "KIZ"));
            Console.WriteLine("18 yaşından büyük mü: " + (nisa.Yas < 18 ? "küçük" : "büyük"));

            Console.WriteLine("İZİN GÜNÜ: " + nisa.IzinGunu);
            Console.WriteLine("MAAS: " + nisa.Maas + " ÇALIŞMA SAATİ" + nisa.CalismaSaati);
            */
            #endregion

            Hayvan kedi = new Hayvan();
            kedi.Adi = "Kedi";
            kedi.KanatliMi = false;

            Hayvan kopek = new Hayvan();
            kopek.Adi = "Köpek";
            kopek.KanatliMi = false;

            List<Hayvan> hayvanlar = new List<Hayvan>();
            hayvanlar.Add(kopek);
            hayvanlar.Add(kedi);

            foreach (var item in hayvanlar)
            {
                Console.WriteLine(item.Adi);
            }
        }
    }
}