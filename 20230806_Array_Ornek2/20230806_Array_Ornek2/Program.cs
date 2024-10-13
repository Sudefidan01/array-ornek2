using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230806_Array_Ornek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ornek 2
            //Kullanıcıdan 3 adet sayı talep edelim
            //Sayıların toplamını ve ortalamasını ekrana yazdıralım
            //Değişken tanımlamasını Array ile yapalım

            int[] toplanacakSayilar = new int[3];

            Console.WriteLine("1.Sayıyı Giriniz : ");
            toplanacakSayilar[0] = int.Parse(Console.ReadLine());

            Console.WriteLine("2.Sayıyı Giriniz : ");
            toplanacakSayilar[1] = int.Parse(Console.ReadLine());

            Console.WriteLine("3.Sayıyı Giriniz : ");
            toplanacakSayilar[2] = int.Parse(Console.ReadLine());

            int toplam = toplanacakSayilar[0] + toplanacakSayilar[1] + toplanacakSayilar[2];
            //Array'ler içerisindeki eleman sayısını .Length komutu ile öğrenebiliriz
            double ortalama = (double)toplam / toplanacakSayilar.Length;

            Console.WriteLine("Sayıların Toplamı : " + toplam);
            Console.WriteLine("Sayıların Ortalaması : " + ortalama);
            Console.WriteLine("Dizinin Boyutu : " + toplanacakSayilar.Length);

            Console.ReadKey();
        }
    }
}
