using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kockak
{
    class NegyszogClass
    {
        private double oldal1, oldal2;
        private double terulet, kerulet;

        // 1. �res konstruktor
        public NegyszogClass()
        {
            oldal1 = 0;
            oldal2 = 0;
            terulet = 0;
            kerulet = 0;
            Console.WriteLine("�res konstruktor h�vva.");
        }

        // 2. Egy param�teres konstruktor (n�gyzet)
        public NegyszogClass(double a)
        {
            oldal1 = a;
            oldal2 = a;
            Console.WriteLine("Egy param�teres konstruktor (n�gyzet) h�vva.");
            SetTerulet();
            SetKerulet();
        }

        // 3. K�t param�teres konstruktor (t�glalap)
        public NegyszogClass(double a, double b)
        {
            oldal1 = a;
            oldal2 = b;
            Console.WriteLine("K�t param�teres konstruktor (t�glalap) h�vva.");
            SetTerulet();
            SetKerulet();
        }

        // SetOldal1: Egy oldal be�ll�t�sa (n�gyzet)
        public void SetOldal1(double a)
        {
            oldal1 = a;
            if (oldal2 == 0) // Ha oldal2 nincs akkor n�gyzetet felt�telez�nk
            {
                oldal2 = a;
            }
            SetTerulet();
            SetKerulet();
        }

        // SetOldal2: K�t oldal be�ll�t�sa (t�glalap)
        public void SetOldal2(double a, double b)
        {
            oldal1 = a;
            oldal2 = b;
            SetTerulet();
            SetKerulet();
        }

        // SetTerulet: Ter�let kisz�m�t�sa
        private void SetTerulet()
        {
            terulet = oldal1 * oldal2;
        }

        // SetKerulet: Ker�let kisz�m�t�sa
        private void SetKerulet()
        {
            kerulet = 2 * (oldal1 + oldal2);
        }

        // GetTerulet: Visszaadja a ter�letet
        public double GetTerulet()
        {
            return terulet;
        }

        // GetKerulet: Visszaadja a ker�letet
        public double GetKerulet()
        {
            return kerulet;
        }
    }
}