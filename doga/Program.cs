using System.Linq;

string adoszam1str = "8  34756 625 9"; //10nak kell lennie
int adoszam1int = 0;
int osszeg = 0;
List<int> adoszam1intlist = new List<int>();
bool isInt = false;
int tempint = 0;

while (!isInt)
{
    Console.WriteLine("Kérek egy adószámot pl'8  34756 625 9' :");
    adoszam1str = Console.ReadLine();

    if (isInt = int.TryParse(adoszam1str[0].ToString(), out tempint))
    {
        isInt = true;
        if (adoszam1str[0].ToString() != "8")
        {
            Console.WriteLine("A számnak 8 al kell kezdődnie");
            isInt = false;

        }
        if (adoszam1str.Count() < 14)
        {
            Console.WriteLine("Túl kevés szám van megadva");
            isInt = false;
        }


    }
    else
    {
        Console.WriteLine("Az megadott szám nem helyes");
    }
}

for (int i = 0; i < adoszam1str.Length - 2; i++)
{
    if (adoszam1str[i] != ' ')
    {
        adoszam1intlist.Add(int.Parse(adoszam1str[i].ToString()));
    }
}

if (adoszam1intlist.Count == int.Parse(adoszam1str[13].ToString()))
{
    for (int i = 0; i < adoszam1intlist.Count; i++)
    {
        var temp = adoszam1intlist[i] * (i + 1);
        osszeg += temp;
        Console.WriteLine(osszeg);
    }
}
Console.WriteLine("Utolso szam:" + adoszam1str[adoszam1str.Count() - 1]);
if (osszeg % 11 == int.Parse(adoszam1str[adoszam1str.Count() - 1].ToString()))
{
    Console.WriteLine(osszeg % 11);
}
else
{
    Console.WriteLine("Nem helyes a adószám");
}