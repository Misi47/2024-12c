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

            // Hibakezelés a bemeneti adatoknál
            while (true)
            {
                try
                {
                    Console.WriteLine("Add meg a háromszög három oldalát:");

                    Console.Write("a: ");
                    a = int.Parse(Console.ReadLine());
                    if (a <= 0) throw new Exception("A háromszög oldalának pozitívnak kell lennie.");

                    Console.Write("b: ");
                    b = int.Parse(Console.ReadLine());
                    if (b <= 0) throw new Exception("A háromszög oldalának pozitívnak kell lennie.");

                    Console.Write("c: ");
                    c = int.Parse(Console.ReadLine());
                    if (c <= 0) throw new Exception("A háromszög oldalának pozitívnak kell lennie.");

                    break; // Ha minden adat helyes, kilépünk a ciklusból
                }
                catch (FormatException)
                {
                    Console.WriteLine("Hibás formátum! Kérlek, egész számot adj meg.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            HTipus haromszog = new HTipus(a, b, c);

            // Háromszög típusainak és területének kiíratása
            Console.WriteLine($"Érvényes háromszög: {haromszog.ErvenyesHaromszog()}");
            Console.WriteLine($"Derékszögû háromszög: {haromszog.DerekszoguHaromszog()}");
            Console.WriteLine($"Egyenlõ szárú háromszög: {haromszog.EgyenloSzaruHaromszog()}");
            Console.WriteLine($"Egyenlõ oldalú háromszög: {haromszog.EgyenloOldaluHaromszog()}");
            Console.WriteLine($"Terület: {haromszog.Terulet():F2}"); // A terület 2 tizedesjegy pontossággal

            Console.ReadLine(); // Hozzáadva, hogy a konzolablak nyitva maradjon
        }
    }
}