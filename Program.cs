using System.IO;
using System.Text;
namespace HelloWorld
{
    class Program
    {
        static List<Csoki> Csoki_Lista = new List<Csoki>();
        static void Main(string[] args)
        {
            Feladat1Beolvasa(); Console.WriteLine();
            Feladat2(); Console.WriteLine();
            Feladat3(); Console.WriteLine();
            Feladat4(); Console.WriteLine();
            Feladat5(); Console.WriteLine();
            Feladat6(); Console.WriteLine();
            Feladat7(); Console.WriteLine();
        }
        static void Feladat7()
        {
            Console.WriteLine("Feldat 7:");
            int db = 0;
            foreach (var cs in Csoki_Lista)
            {
                if (cs.Nev.ToUpper().Contains('K'))
                {
                    db++;
                }

            }
            Console.WriteLine($"Ennyi alkalommal volt 'K' a termékek nevében: {db}");
        }
        static void Feladat6()
        {
            Console.WriteLine("Feladat 6: Kód");
            Console.WriteLine("Adjon meg egy kódot");
            string code = Console.ReadLine();
            int szamlalo = 0;
            while (szamlalo < Csoki_Lista.Count && Csoki_Lista[szamlalo].Kod != code)
            { szamlalo++; }
            if(szamlalo == Csoki_Lista.Count) { Console.WriteLine("Nincs ilyen termék"); }
            else { Console.WriteLine($"Van ilyen termék -> {Csoki_Lista[szamlalo].Nev}: {Csoki_Lista[szamlalo].Ar}"); }

        }
        static void Feladat5()
        {
            Console.WriteLine("Feladat 5:");
            int Osszeg = 0;
            foreach (var cs in Csoki_Lista)
            {
                Osszeg += cs.Ar;
            }
            Console.WriteLine($"Ha minden csokiból vennénk egy darabot ennyibe Ft-be kerülne: {Osszeg}Ft");
        }
        static void Feladat4()
        {
            Console.WriteLine("Feladat 4:");
            foreach (var cs in Csoki_Lista)
            {
                if (cs.Ar <= 150) { Console.WriteLine($"{cs.Nev}, {cs.Ar}"); }
            }
        }
        static void Feladat3()
        {
            Console.WriteLine("Feladat 3: Legdrágább");
            int MaxAr = int.MaxValue;
            string MaxCsoki = "cica";
            foreach (var cs in Csoki_Lista)
            {
                if (MaxAr < cs.Ar)
                {
                    MaxCsoki = cs.Nev;
                    MaxAr = cs.Ar;
                }
            }
            Console.WriteLine($"A legdrágább csoki: {MaxCsoki} és az ára: {MaxAr}");
        }

        static void Feladat2()
        {
            Console.WriteLine("Fealdat 2");
            Console.WriteLine($"Beolvasott sorok száma: {Csoki_Lista.Count}");
        }

        static void Feladat1Beolvasa()
        {
            Console.WriteLine("Feladat 1: Beolvasás");
            var sr = new StreamReader(@"csoki.txt", Encoding.UTF8);
            int db = 0;
            while (!sr.EndOfStream)
            {
                Csoki_Lista.Add(new Csoki(sr.ReadLine()));
                db++;
            }
            sr.Close();
            if (db > 0) { Console.WriteLine($"Sikeres beolvasás! {db}"); }
            else { Console.WriteLine($"Sikertelen beolvasás"); }
        }
    }
}