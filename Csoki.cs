namespace HelloWorld
{
    internal class Csoki
    {
        public string Nev;
        public string Kod;
        public int Ar;
        public int Darabszam;

        public Csoki(string Sor)
        {
            var dbok = Sor.Split(';');
            this.Nev = dbok[0];
            this.Kod = dbok[1];
            this.Ar = int.Parse(dbok[2]);
            this.Darabszam = int.Parse(dbok[3]);
        }
    }
}