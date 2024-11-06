using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace ConsoleApp2

{

    class Program

    {
    static void Main(string[] args)
        {
            //A kor osztály felhasználása
            #region 1.objektum
            //Első objektum

            kor k1 = new kor(); // Objektum példány létrehozása üresen
            k1.ReadSugar(15.0); // Sugár megadása
            k1.SetKerulet();
            k1.SetTerulet();
            Console.WriteLine($"A {k1.GetSugar()} sugarú kör kerülete{k1.GetKerulet()}, területe{k1.GetTerulet()}");
            #endregion EOF 1.objektum

            #region 2.objektumunk
            kor k2 = new kor(28.7);
            k2.SetKerulet();
            k2.SetTerulet();
            Console.WriteLine($"A {k2.GetSugar()} sugarú kör kerülete{k2.GetKerulet()}, területe{k2.GetTerulet()}");
            #endregion EOF 2.objektum


            Console.ReadKey();

        }

    }

}

