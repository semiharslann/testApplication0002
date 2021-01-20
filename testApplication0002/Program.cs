using System;
using System.Threading;

namespace testApplication0002
{
    class Program
    {
        static void Main(string[] args)
        {

            char cevap;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Merhaba kelimesinin hangi dilde yazılmak istediğini seçin:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("İngilizce için 1\nAlmanca için 2\nİtalyanca için 3\nİspanyolca için 4 yazınız.");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Seçiminiz = ");
            cevap = Convert.ToChar(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            switch (cevap)
            {
                case '1': Console.WriteLine("Result =" + "Hi"); break;
                case '2': Console.WriteLine("Ergebnis = Hallo"); break;
                case '3': Console.WriteLine("Risultato = Ciao"); break;
                case '4': Console.WriteLine("Resultado = Hola"); break;
                default: Console.WriteLine("Lütfen belirtilen sayılardan birini giriniz!"); break;
            }
            Console.WriteLine(" ");

            char secim;
            int sayi1;
            Console.Write("Lütfen bir sayı girin: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçin:");
            Console.WriteLine("Sayının karesi için 1\nSayının kübü için 2\nSayının karekökü için 3  yazınız.");
            Console.Write("Seçiminiz: ");
            secim = Convert.ToChar(Console.ReadLine());
            switch (secim)
            {
                case '1': Console.WriteLine("Karesi = " + (sayi1 * sayi1)); break;
                case '2': Console.WriteLine("Kübü = " + (sayi1 * sayi1 * sayi1)); break;
                case '3': Console.WriteLine("Karekökü = " + Math.Sqrt(sayi1)); break;
            }

            byte ay;
            ay = Convert.ToByte(DateTime.Today.Month);
            switch (ay)
            {
                case 12:
                case 1:
                case 2: Console.WriteLine("Kış"); break;
                case 3: 
                case 4:
                case 5: Console.WriteLine("İlkbahar"); break;
                case 6: 
                case 7: 
                case 8: Console.WriteLine("Yaz"); break;
                default: Console.WriteLine("SONBAHAR"); break; 
            }

            int adet, oran;
            double fiyat, toplam, kdv, kdvtoplam;
            Console.Write("Adet bilgisini giriniz = ");
            adet = Convert.ToInt32(Console.ReadLine());
            Console.Write("Fiyat bilgisini giriniz = ");
            fiyat = Convert.ToDouble(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("KDV Oranlarımızdan birini seçiniz:\n- 8\n- 18\n- 25");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Seçiminiz = ");
            oran = Convert.ToInt32(Console.ReadLine());
            toplam = adet * fiyat;
            Thread.Sleep(1000);
            Console.WriteLine("Toplam fiyat = " + toplam);
            switch (oran)
            {
                case 8:
                    kdv = toplam * 0.08; kdvtoplam = toplam + kdv; Thread.Sleep(1000);
                    Console.Write("KDV fiyatı = " + kdvtoplam); break;
                case 18:
                    kdv = toplam * 0.18; kdvtoplam = toplam + kdv; Thread.Sleep(1000);
                    Console.Write("KDV fiyatı = " + kdvtoplam); break;
                case 25:
                    kdv = toplam * 0.25; kdvtoplam = toplam + kdv; Thread.Sleep(1000);
                    Console.Write("KDV fiyatı = " + kdvtoplam); break;
                default: Console.WriteLine("KDV Oranı yanlış!"); break;
            }
        }
    }
}
