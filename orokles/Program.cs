using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace ConsoleApp14

{

    /*Példa  a következőkre:

     * virtual, override

     * A virtual kulcsszó azt jelzi, hogy egy metódus property relülírható egy származtatott osztályban, a virtual tagok alapértelmezett

     * viselkedést biztosítanak, az osztályban, de a származtatott osztályban az override kulcsszóval módosíthatjuk azt a viselkedést

     * sealed

     * A sealed kulcsszó lezárja az osztályokat vagy metódusokat a továbba örökléstől vagy felülírástól, ezáltal biztosítva a stabilitását, és

     * a logika változatlanságát a kódbázisban.

     */


    class Allat

    {

        //properties

        public string Name { get; set; }

        public string Hang { get; set; }

        //Konstruktorok

        public Allat()

        {

            this.Name = "Anonim";

            this.Hang = "Én egy Állat vagyok";

        }

        public Allat(string name)

        {

            this.Name = name;

            this.Hang = "Én egy állat vagyok";

        }

        public void hangotAd()

        {

            Console.WriteLine("Ezt a Állat.hangotAd() metódus írta ki");

            Console.ReadKey();

        }

        // Virtuális metódus

        public virtual void mozog()

        {

            Console.WriteLine("Ezt a virtuális mozog() metódus írta ki");

            Console.ReadKey();

        }

    }

    //ok

    class Kutya : Allat
    {

        public Kutya() : base()

        {

            this.Hang = "Én egy kutya vagyok";

            Console.ReadKey();

        }

        //Átlagos metódus felülírása(shadow hatás)

        public void hangotAd()

        {

            Console.WriteLine("Ezt a kutya.hangotAd() metódus írta ki");

            Console.ReadKey();

        }

        public sealed override void mozog()

        {

            Console.WriteLine("Ezt a lezárt mozog() metódus írta ki");

            Console.ReadKey();

        }

    }

    class Komondor : Kutya

    {

        //Lezárt metódust nem írhatunk felül

        //public override void mozog()

        //{

        // Console.WriteLine

        //("Elindultam");

        public void mozog()

        {

        }
      

    }
    // osztály lezárása

    sealed class Macska : Allat 
    {
        public Macska() 
        {
            this.Name = "Cicamica";
        }
    }
    /*//Lezárt osztályból nem származtatható
     class Sziami:Macska{}
     */
}

