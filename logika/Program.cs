using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logika
{
    class Program
    {
        static void Main(string[] args)
        {
            #region És kapcsolat

            bool a = true;
            bool b = false;



            Console.WriteLine("Az és (&&) kapcsolat");
            Console.WriteLine($"Ha a={a} és b={b}, akkor a&&b={a && b}");

            a = false;
            b = true;

            Console.WriteLine($"Ha a={a} és b={b}, akkor a&&b={a && b}");

            a = false;
            b = false;

            Console.WriteLine($"Ha a={a} és b={b}, akkor a&&b={a && b}");


            #endregion És kapcsolat

            #region Vagy kapcsolat

            a = true;
            b = false;

            Console.WriteLine("\n Az vagy (||) kapcsolat");
            Console.WriteLine($"Ha a={a} és b={b}, akkor a||b={a || b}");

            a = false;
            b = true;

            Console.WriteLine($"Ha a={a} és b={b}, akkor a||b={a && b}");

            a = false;
            b = false;

            Console.WriteLine($"Ha a={a} és b={b}, akkor a||b={a && b}");


            #endregion vagy kapcsolat

            Console.ReadKey();


        }
    }
}
