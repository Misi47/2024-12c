using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kockak
{
    class Program
    {
        static void Main(string[] args)
        {
            // �res konstruktor
            NegyszogClass negyszog1 = new NegyszogClass();
            Console.WriteLine($"Ter�let: {negyszog1.GetTerulet()}, Ker�let: {negyszog1.GetKerulet()}");

            // N�gyzet konstruktor
            NegyszogClass negyszog2 = new NegyszogClass(4);
            Console.WriteLine($"Ter�let: {negyszog2.GetTerulet()}, Ker�let: {negyszog2.GetKerulet()}");

            // T�glalap konstruktor
            NegyszogClass negyszog3 = new NegyszogClass(4, 5);
            Console.WriteLine($"Ter�let: {negyszog3.GetTerulet()}, Ker�let: {negyszog3.GetKerulet()}");

            // SetOldal1 teszt
            negyszog1.SetOldal1(6);
            Console.WriteLine($"Ter�let: {negyszog1.GetTerulet()}, Ker�let: {negyszog1.GetKerulet()}");

            // SetOldal2 teszt
            negyszog1.SetOldal2(6, 7);
            Console.WriteLine($"Ter�let: {negyszog1.GetTerulet()}, Ker�let: {negyszog1.GetKerulet()}");

            Console.ReadKey();
        }
    }
}