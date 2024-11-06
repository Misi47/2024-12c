using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kor

{

    class Program

    {
    static void Main(string[] args)
        {
            //A kor osztály felhasználása
            #region kor
            //Első objektum

            kor k1 = new kor(); // Objektum példány létrehozása üresen
            k1.ReadSugar(15.0); // Sugár megadása
            k1.SetKerulet();    // Kerület kiszámítása
            k1.SetTerulet();    // Terület kiszámítása
            Console.WriteLine($"A {k1.GetSugar()} sugarú kör kerülete{k1.GetKerulet()}, területe{k1.GetTerulet()}");
            #endregion kor vége

            #region második kor
            kor k2 = new kor(28.7); // Sugár megadása
            k2.SetKerulet();        // Kerület kiszámítása
            k2.SetTerulet();        // Terület kiszámítása
            Console.WriteLine($"A {k2.GetSugar()} sugarú kör kerülete{k2.GetKerulet()}, területe{k2.GetTerulet()}");
            #endregion kor második váge

            #region kor2 használata
            kor2 k21 = new kor2(24.5);
            Console.WriteLine($"a kör adatai: \nsugár={k21.GetSugár()}\nterület={k21.GetTerület()}\nkerület={k21.GetKerület()}");
            #endregion kor2 vége

            #region henger használata
            henger h1 = new henger(15, 30);
            Console.WriteLine($"\n\nhenger adatai: \nsugara={h1.GetSugar()} \nmagassag={h1.GetMagassag()} \nalapterület={h1.GetTerulet()} \ntérfogata={h1.GetTérfogat()}");
            #endregion henger vége

            Console.ReadKey();

        }

    }

}

