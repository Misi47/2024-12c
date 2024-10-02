using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace macskak
{
    class Program
    {
        enum animal {macska, kutya, tigris, farkas}
        static void Main(string[] args)
        {
            animal b = animal.farkas;
            animal c = animal.macska;

            if (b==animal.farkas)
            {
                Console.WriteLine("A b állat farkas");
            }
            if (c == animal.macska)
            {
                Console.WriteLine("A c állat macska");
            }
            Console.ReadKey();
        }
    }
}
