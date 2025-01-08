using System;

namespace HaromszogTipusaOOP
{
    class HTipus
    {
        private int a, b, c;

        public HTipus(int a, int b, int c)
        {

            if (a <= 0 || b <= 0 || c <= 0)
                throw new Exception("Az oldalhossz�s�goknak pozit�v sz�mnak kell lenni�k!");

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
            if (!ErvenyesHaromszog()) return 0;

            double s = (a + b + c) / 2.0;

            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;


            Console.WriteLine("Add meg a h�romsz�g h�rom oldal�t:");


            a = GetValidInput("a");
            if (a == 0)
            {
                Console.WriteLine("Hib�s �rt�k! K�rem, adjon meg egy pozit�v sz�mot.");
                Console.ReadKey();
                return;

            }


            b = GetValidInput("b");
            if (b == 0)
            {
                Console.WriteLine("Hib�s �rt�k! K�rem, adjon meg egy pozit�v sz�mot.");
                Console.ReadKey();
                return;

            }


            c = GetValidInput("c");
            if (c == 0)
            {
                Console.WriteLine("Hib�s �rt�k! K�rem, adjon meg egy pozit�v sz�mot.");
                Console.ReadKey();
                return;

            }

            try
            {
                HTipus haromszog = new HTipus(a, b, c);

                Console.WriteLine($"�rv�nyes h�romsz�g: {haromszog.ErvenyesHaromszog()}");
                Console.WriteLine($"Der�ksz�g� h�romsz�g: {haromszog.DerekszoguHaromszog()}");
                Console.WriteLine($"Egyenl� sz�r� h�romsz�g: {haromszog.EgyenloSzaruHaromszog()}");
                Console.WriteLine($"Egyenl� oldal� h�romsz�g: {haromszog.EgyenloOldaluHaromszog()}");
                Console.WriteLine($"Ter�let: {haromszog.Terulet()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hiba: {ex.Message}");
            }

            Console.ReadLine();
        }


        static int GetValidInput(string side)
        {
            int value;
            while (true)
            {
                Console.Write($"{side}: ");
                string input = Console.ReadLine();

                try
                {
                    int.TryParse(input, out value);
                }

                catch
                {
                    return 0;
                }

                return value;
            }
        }
    }
}