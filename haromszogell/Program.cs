using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaromszogTipusaOOP
{
    class HTipus
    {
        private int a, b, c;

        public HTipus(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public bool ErvenyesHaromszog()
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }

        public bool DerekszoguHaromszog()
        {
            if (!ErvenyesHaromszog()) return false;
            int[] oldalak = { a, b, c };
            Array.Sort(oldalak);
            return (oldalak[0] * oldalak[0] + oldalak[1] * oldalak[1] == oldalak[2] * oldalak[2]);
        }

        public bool EgyenloSzaruHaromszog()
        {
            if (!ErvenyesHaromszog()) return false;
            return (a == b) || (a == c) || (b == c);
        }

        public bool EgyenloOldaluHaromszog()
        {
            if (!ErvenyesHaromszog()) return false;
            return (a == b) && (b == c);
        }

        public double Terulet()
        {
            if (!ErvenyesHaromszog()) return 0.0;
            double s = (a + b + c) / 2.0;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, c = 0;

            // Hibakezel�s a bemeneti adatokn�l
            while (true)
            {
                try
                {
                    Console.WriteLine("Add meg a h�romsz�g h�rom oldal�t:");

                    Console.Write("a: ");
                    a = int.Parse(Console.ReadLine());
                    if (a <= 0) throw new Exception("A h�romsz�g oldal�nak pozit�vnak kell lennie.");

                    Console.Write("b: ");
                    b = int.Parse(Console.ReadLine());
                    if (b <= 0) throw new Exception("A h�romsz�g oldal�nak pozit�vnak kell lennie.");

                    Console.Write("c: ");
                    c = int.Parse(Console.ReadLine());
                    if (c <= 0) throw new Exception("A h�romsz�g oldal�nak pozit�vnak kell lennie.");

                    break; // Ha minden adat helyes, kil�p�nk a ciklusb�l
                }
                catch (FormatException)
                {
                    Console.WriteLine("Hib�s form�tum! K�rlek, eg�sz sz�mot adj meg.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            HTipus haromszog = new HTipus(a, b, c);

            // H�romsz�g t�pusainak �s ter�let�nek ki�rat�sa
            Console.WriteLine($"�rv�nyes h�romsz�g: {haromszog.ErvenyesHaromszog()}");
            Console.WriteLine($"Der�ksz�g� h�romsz�g: {haromszog.DerekszoguHaromszog()}");
            Console.WriteLine($"Egyenl� sz�r� h�romsz�g: {haromszog.EgyenloSzaruHaromszog()}");
            Console.WriteLine($"Egyenl� oldal� h�romsz�g: {haromszog.EgyenloOldaluHaromszog()}");
            Console.WriteLine($"Ter�let: {haromszog.Terulet():F2}"); // A ter�let 2 tizedesjegy pontoss�ggal

            Console.ReadLine(); // Hozz�adva, hogy a konzolablak nyitva maradjon
        }
    }
}