using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1.objektum
            //A kor osztály felhasználása
            //Első objektum
            kor K1 = new kor(); //Objektum példány létehozása üresen
            K1.ReadSugar(15.0); //Sugar megadása
            K1.SetKerulet();
            K1.SetTerulet();
            Console.WriteLine($"{K1.GetSugar()} sugarú kör kerülete:{K1.GetKerulet()}, területe:{K1.GetTerulet()} ");
            #endregion 1. objektum vége


            #region 2. objektum
            kor K2 = new kor(28.7);
            K2.SetKerulet();
            K2.SetTerulet();
            Console.WriteLine($"{K2.GetSugar()} sugarú kör kerülete:{K2.GetKerulet()}, területe:{K2.GetTerulet()} ");
            #endregion

            Console.ReadKey();

        }
    }
}
