class Program

{

    static void Main(string[] args)

    {

        Teglalapszamitasok teglaszam = new Teglalapszamitasok();

        teglaszam.ReadAoldal(15);

        teglaszam.ReadBoldal(25);

        teglaszam.TeruletSzam();

        teglaszam.KeruletSzam();

        Console.WriteLine($"A kerület az : {teglaszam.GetKerulet()} A terület: {teglaszam.GetTerulet()}");

        Console.ReadKey();

    }

}
