using System;
//using System.Linq;

namespace Lernen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gib den ersten Summanden ein:");
            string ersterSummand = Console.ReadLine();
            Console.Write("Gib den zweiten Summanden ein:");
            string zweiterSummand = Console.ReadLine();

            //Wandlung von string in double
            decimal ersterSummandZahl = Convert.ToDecimal(ersterSummand);
            decimal zweiterSummandZahl = Convert.ToDecimal(zweiterSummand);

            decimal summe = ersterSummandZahl + zweiterSummandZahl;
            Console.WriteLine("Die Summe ist: {0}",summe);
            Console.ReadKey();
        }
    }
}
