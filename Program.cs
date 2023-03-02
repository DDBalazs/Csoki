using System.IO;
using System.Text;
namespace HelloWorld
{
    class Program
    {
        static List<Csoki> Csoki_Lista = new List<Csoki>();
        static void Main(string[] args)
        {
            Feladat1Beolvasa();
            Feladat2();
            Feladat3();
        }

        static void Feladat3()
        {
            Console.WriteLine("Feladat 3: Legdrágább");
            int MaxAr = int.MaxValue;
            string MaxCsoki = "cica";
            foreach(var cs in Csoki_Lista)
            {
                if(MaxAr < cs.Ar)
                {
                    MaxCsoki = cs.Nev;
                    MaxAr = cs.Ar;
                }
            }
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