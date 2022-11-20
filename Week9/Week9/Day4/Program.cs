using System;
using System.Diagnostics;

Console.WriteLine();

#region Math
string ayrac = new string('-', 20);
int intParametre1, intParametre2;
double doubleParametre;
Console.WriteLine("{0}\n-> C# Math Kütüphanesi Elemanları\n{1}", ayrac, ayrac);
Console.Write("-> Lütfen Integer Veri Tipinde Parametre Biri Girin: ");
intParametre1 = Convert.ToInt32(Console.ReadLine());
Console.Write("-> Lütfen Integer Veri Tipinde Parametre İkiyi Girin: ");
intParametre2 = Convert.ToInt32(Console.ReadLine());
Console.Write("-> Lütfen Double Veri Tipinde Bir Değer Girin: ");
doubleParametre = Convert.ToDouble(Console.ReadLine());
Console.Clear(); //--> Konsol Temizlenecek.
Console.WriteLine("{0}\n-> Integer Veri - [Parametre1]: {1}\n-> Integer Veri - [Parametre2]: {2}\n-> Double Veri - [Parametre1]: {3}\n{4}", ayrac, intParametre1, intParametre2, doubleParametre, ayrac);
Console.WriteLine("-> Math.Pow({0},{1}) Sonucu: {2}\n-> Math.Sqrt({3}) Sonucu: {4}", intParametre1, intParametre2, Math.Pow(intParametre1, intParametre2), intParametre1, Math.Sqrt(intParametre1));
Console.WriteLine("-> Math.Abs({0}) Sonucu: {1}\n-> Math.Floor({2}) Sonucu: {3}", (-intParametre1), Math.Abs(-intParametre1), doubleParametre, Math.Floor(doubleParametre));
Console.WriteLine("-> Math.Ceiling({0}) Sonucu: {1}\n-> Math.Max({2},{3}) Sonucu: {4}", doubleParametre, Math.Ceiling(doubleParametre), intParametre1, intParametre2, Math.Max(intParametre1, intParametre2));
Console.WriteLine("-> Math.Min({0},{1}) Sonucu: {2}\n{3}", intParametre2, intParametre1, Math.Min(intParametre2, intParametre1), ayrac);



string ayrac = new string('-', 20);
Console.WriteLine("{0}\n-> C# Trigonometri Metotları\n{1}\n1-> Math.Sin(90) Kullanımı: {2}\n2-> Math.Asin(1) Kullanımı: {3}", ayrac, ayrac, Math.Sin(90), Math.Asin(1));
Console.WriteLine("3-> Math.Cos(60) Kullanımı: {0}\n4-> Math.Acos(1) Kullanımı: {1}\n5-> Math.Tan(180) Kullanımı: {2}\n6-> Math.Atan(0) Kullanımı: {3}\n{4}\n", Math.Cos(60), Math.Acos(1), Math.Tan(180), Math.Atan(0), ayrac);
Console.WriteLine("{0}\n-> Trigonometri Sabit Değerleri\n{1}\n-> Math.PI Kullanımı: {2}\n-> Math.E Kullanımı: {3}\n{4}", ayrac, ayrac, Math.PI, Math.E, ayrac);

double x = Math.Log(100);
double y = Math.Log10(1000);
double z = Math.Log(16, 2);
// Ekrana Yazdırma:
Console.WriteLine("{0}\n-> C# Logaritma Metotları\n{1}\n-> Math.Log(100) İşleminin Sonucu: {2}\n-> Math.Log10(1000) İşleminin Sonucu: {3}\n-> Math.Log(16,2) İşleminin Sonucu: {4}\n{5}", ayrac, ayrac, x, y, z, ayrac);

#endregion


#region DateTime

//
//DateTime yeniTarih = new DateTime(yıl, ay, gün);
//DateTime yeniTarih2 = new DateTime(yıl, ay, gün, saat, dakika, saniye);


DateTime bugun = DateTime.Now;
Console.WriteLine("Uygulamayı " + bugun + " tarihinde çalıştırdın.");

DateTime tarih = new DateTime(2017, 11, 10, 9, 5, 0);
Console.WriteLine(tarih + " tarihinde M.Kemal Atatürk aramızdan ayrıldı.");


DateTime tarih2 = new DateTime(2022, 1, 1);
Console.WriteLine(tarih + " tarihi yeni yıl başlangıcıdır.");
tarih2 = tarih2.AddYears(1);
Console.WriteLine(tarih + " tarihi de yeni yıl başlangıcıdır.");


DateTime ilkTarih = new DateTime(2017, 12, 3);
DateTime ikinciTarih = new DateTime(2018, 1, 1);

TimeSpan span = ikinciTarih.Subtract(ilkTarih);

Console.WriteLine("{0} gün sonra 2018 yılına gireceğiz.", span.TotalDays);

 
Console.WriteLine("Bugün günlerden: " + bugun.DayOfWeek);



DateTime tarih3 = DateTime.Now;//bugünün tarihinin alınması
string format = "MMM ddd d HH:mm yyyy";//tarihe uygulanacak format.
Console.WriteLine(tarih3.ToString(format));

#endregion



//Stopwatch

List<int> numbers = new List<int>();
for (int i = 1; i <= 1000; i++)
    numbers.Add(i);

Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();

for (int i = 0; i < numbers.Count; i++) {
    Console.WriteLine(numbers[i]);
    Thread.Sleep(10);
}

stopwatch.Stop();
Console.WriteLine($"Time elapsed (For): {stopwatch.Elapsed}");

Console.ReadLine();


