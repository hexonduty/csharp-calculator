using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Açıkgöz Hesap Makinesine Hoş Geldiniz...");
            Console.WriteLine("Sizlere nasıl yardımcı olabilirim.");
            Console.WriteLine("1. Toplama");
            Console.WriteLine("2. Çıkarma");
            Console.WriteLine("3. Çarpma");
            Console.WriteLine("4. Bölme");

            Console.WriteLine("Bir işlem Seçiniz..");
            int secim = Convert.ToInt32(Console.ReadLine());

            Console.Write("Birinci sayıyı giriniz: ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());


            Console.Write("İkinci sayıyı giriniz: ");
            double sayi2 = Convert.ToDouble(Console.ReadLine());

            double sonuc = 0;

            switch (secim)
            {
                case 1:
                    sonuc = Toplama(sayi1, sayi2);
                    break;

                case 2:
                    sonuc = Cikarma(sayi1, sayi2);
                    break;

                case 3:
                    sonuc = Carpma(sayi1, sayi2);
                    break;

                case 4:
                    sonuc = Bolme(sayi1, sayi2);
                    break;

                default:
                    Console.WriteLine("Geçersiz bir seçim yaptınız");
                    break;
                      
            }

            Console.WriteLine($"Sonuç:  {sonuc}");
        }

        static double Toplama(double x, double y)
        {
            return x + y;
        }
        static double Cikarma(double x, double y)
        {
            return x - y;
        }
        static double Carpma(double x, double y)
        {
            return x * y;
        }
        static double Bolme(double x, double y)
        {
            if (y != 0)
            {
                return x / y;
            }
            else
            {
                Console.WriteLine("Bir sayıyı sıfıra bölemezsiniz1!!");
                return 0;
            }
        }
    }
}
