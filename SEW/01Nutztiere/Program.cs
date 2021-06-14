using System;

namespace _01Nutztiere
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testprogramm für 2. Test");
            Nutztier wooly = new Schaf("Wooly", 70, 450);
            Console.WriteLine(wooly);
            Console.WriteLine(wooly.Lieblingsfutter());

            Schaf alma = new Schaf("Alma", 80, 470);
            Console.WriteLine(alma);
            Console.WriteLine(alma.Lieblingsfutter());
            Console.WriteLine("Milchleistung in kg: " + alma.MilchleistungInKg);
            alma.MilchleistungInKg = 430;
            Console.WriteLine("Nach einer Futterumstellung liegt die Milchleistung bei: " + alma.MilchleistungInKg);
        }
    }
}
