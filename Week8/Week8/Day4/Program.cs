// See https://aka.ms/new-console-template for more information
using Week8.Day4;

Console.WriteLine("Hello, World!");

#region Matematik sınıfı
//Matematik matematik = new Matematik(); 
//int pisayisi = matematik.pi;

//int sonuc = matematik.Carpma(2, 4);

//Console.WriteLine("PI SAYISI : " + pisayisi);
//Console.WriteLine("CARPMA SONUCU : " + sonuc);
#endregion

Araba yaris = new Araba();
yaris.renk = "kırmızı";
yaris.model = "yaris";
yaris.marka = "toyota";
yaris.kapisayisi = 4;
yaris.motorgucu = 1.4;

int hiz = yaris.hizlan(0);
hiz = yaris.fren(hiz);

yaris.sescikar();