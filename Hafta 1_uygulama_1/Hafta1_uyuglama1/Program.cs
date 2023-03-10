using System;


namespace Hafta1_uyuglama1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello C#");

            Console.ReadKey();  //Tusa basilmasini bekliyor

            

            
            int sayi;

            Console.Write("Sayi gir");
            sayi = Convert.ToInt32(Console.ReadLine());

            //Ayni sey
            Console.WriteLine("Girilen sayi " + sayi); 
            Console.WriteLine("Girilen sayi {0} {1}" , sayi , " olarak girildi");

            //Ayni sey
            Console.ReadKey();
            Console.ReadLine();

            

            //Girilen iki sayiyi toplamini yazma
            int sayi1, sayi2, top;

            Console.WriteLine("Iki sayi toplamı ");
            Console.Write("1. sayi ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayi ");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            top = sayi1 + sayi2;
            Console.WriteLine("Girilen sayilarin toplami  " + top);
            Console.ReadKey();

            

            //Bolme islemi
            int bolum = 50;
            int bolen = 8;
            int kalan = bolum % bolen;
            int sonuc = bolum / bolen;
            Console.WriteLine("{0}/{1}={2}" , bolum,bolen,sonuc);
            Console.WriteLine("{0} mod {1}={2}", bolum, bolen, kalan);

            Console.ReadKey();

            
            
            //Cumleyi kelime kelime ayirma
            string cumle;
            Console.WriteLine("Bir cumle");
            cumle= Console.ReadLine();
            string[] kelime = cumle.Split(' ');

            for(int i = 0;i< kelime.Length;i++)
            {
                Console.WriteLine(kelime[i]);
            }

            Console.ReadKey();
            

            // Ust alma 
            double taban, us;
            Console.WriteLine("Taban gir ");
            taban = Convert.ToDouble(Console.ReadLine());
            Console.Write("Üst gir ");
            us = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0}^{1}={2}", taban,us,Math.Pow(taban,us));

            Console.ReadLine();
        }
    }
}
