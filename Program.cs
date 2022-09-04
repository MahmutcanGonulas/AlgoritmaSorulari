using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sorular cevap = new();
            //Soru1
            //Console.WriteLine("Pozitif bir sayi gir");
            //int sayi=Convert.ToInt32(Console.ReadLine());
            //cevap.Soru1(sayi);

            //Soru2
            //cevap.Soru2();

            //Soru3
            //cevap.Soru3();

            //Soru4
            cevap.Soru4();



        }
    }

    class Sorular
    {
        public void Soru1(int sayi)
        {
            if (sayi > 0)
            {
                for (int i = 0; i <= sayi; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }

            }
            else
            {
                Console.WriteLine("Pozitif deger gir");
            }
        }

        public void Soru2()
        {
            Console.Write("1. Pozitif sayi gir --> ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Pozitif sayi gir --> ");
            int m = Convert.ToInt32(Console.ReadLine());
            int[] nDizi = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine((i + 1) + ".Sayiyi gir");
                nDizi[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (var item in nDizi)
            {
                if (item % m == 0)
                {
                    Console.WriteLine(item);
                }
            }
        }
        public void Soru3()
        {
            Console.WriteLine("Pozitif bir sayi gir");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi > 0)
            {
                string[] dizi = new string[sayi];
                for (int i = 0; i < dizi.Length; i++)
                {
                    Console.WriteLine((i + 1) + ". Kelimeyi gir");
                    dizi[i] = Console.ReadLine();
                }

                Array.Reverse(dizi);

                for (int i = 0; i < dizi.Length; i++)
                {
                    Console.WriteLine((i + 1) + ". Kelime = "+dizi[i] );

                }
            }
            else
            {
                Console.WriteLine("Sayinin 0'dan büyük olması lazım");
            }
        }

        public void Soru4(){
            string cumle;
            Console.WriteLine("Bir cümle girin");
            cumle=Console.ReadLine().Trim();
            
            Console.WriteLine(cumle);
            string[] kelime = cumle.Split(" ");
            Console.WriteLine("Kelime Sayisi = "+ kelime.Length); 
            string harf=cumle.Replace(" ","");
            Console.WriteLine(harf);
            Console.WriteLine("Harf Sayisi = "+harf.Length );



            
            
        }
    }
}