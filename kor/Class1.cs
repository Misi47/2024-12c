using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2

{

    class kor

    {

        // Az osztály feladata: a sugárból kiszámítja a kör területét, kerületét//

        //konstruktorok szerepe a példányosítás //

        //osztályváltozók//

        private double sugar,
            kerulet,
            terulet;

        //konstruktorok
        public kor() { }
        public kor(double r)
        {
            this.sugar = r;
        }
        public void ReadSugar(double r)
        {
            this.sugar = r;
        }
        public void SetKerulet()

        {
            this.kerulet = 2 * this.sugar * Math.PI;
        }
        public void SetTerulet()
        {
            double eredmeny = 0.0,
            eredmeny2 = 0.0;
            eredmeny = this.sugar * this.sugar * Math.PI;
            eredmeny2 = Math.Pow(this.sugar, 2) * Math.PI;
            if (eredmeny == eredmeny2)
            {
                this.terulet = eredmeny;
            }
            else
            {
                Console.WriteLine($"Eredmény1 ({eredmeny})= Eredmény2({eredmeny2}");
            }

        }
        public double GetKerulet() { return this.kerulet; }
        public double GetTerulet() { return this.terulet; }
        public double GetSugar() { return this.sugar; }


    }

}

 
