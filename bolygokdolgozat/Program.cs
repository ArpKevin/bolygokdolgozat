namespace bolygokdolgozat
{
    class Program
    {
        private static void Main(string[] args)
        {
            var bolygok = new List<Bolygo>();

            using var sr = new StreamReader(@"..\..\..\src\solsys.txt");

            while (!sr.EndOfStream)
            {
                bolygok.Add(new Bolygo(sr.ReadLine()));
            }

            Console.WriteLine("3.feladat:");

            Console.WriteLine($"\t3.1: {bolygok.Count} bolygó van a naprendszerben");

            Console.WriteLine($"\t3.2: Egy naprendszerben egy bolygónak átlagosan {bolygok.Average(b => b.HoldakSzama)} holdja van");

            Console.WriteLine($"\t3.3: A legnagyobb térfogató bolygó a {bolygok.MaxBy(b => b.TerfogatArany).Nev}");

            Console.Write("\t3.4: írd be a keresett bolygó nevét: ");
            string bolygoInput = Console.ReadLine();

            Console.WriteLine($"\t\t{(bolygok.Exists(b => b.Nev == bolygoInput) ? "van" : "sajnos nincs")} ilyen bolygó a naprendszerben");

            Console.Write("\t3.5 Írj be egy számot: ");
            int bekertSzam = int.Parse(Console.ReadLine());

            string[] holdasBolygok = bolygok.Where(b => b.HoldakSzama > bekertSzam).Select(b => b.Nev).ToArray();

            Console.WriteLine($"\t\tA következő bolygóknak van {bekertSzam}-nál/nél több holdja:");

            Console.Write("\t\t");

            string holdayBolygokString = string.Join(", ", holdasBolygok);

            Console.WriteLine(holdayBolygokString);
        }
    }
}