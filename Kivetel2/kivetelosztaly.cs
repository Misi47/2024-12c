using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kivetel2
{
    class kivetelosztaly
    {
        public kivetelosztaly()
        {

        }
        public void kivKezNincs()
        {
            Console.WriteLine("Nincs kivételezés\nAdjon meg egy karaktert! ");
            int szam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"A beírt szám: {szam}");
            Console.ReadKey();
        }
        public void kivKezAlt()
        {
            Console.WriteLine("\nhiba objektum nélküli kivételezés \n Adjon meg egy karaktert!");
            try
            {
                int szam = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                throw;
            }
            Console.ReadKey();
        }
        public void kivKez0s()
        {
            Console.WriteLine("\nős hiba objektummal kivételezés \n Adjon meg egy karaktert!");
            try
            {
                int szam = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"A beírt szám{szam}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadKey();
        }
    }
}