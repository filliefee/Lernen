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

            //Wandlung von string in int
            int ersterSummandZahl = Convert.ToInt32(ersterSummand);
            int zweiterSummandZahl = Convert.ToInt32(zweiterSummand);

            Console.WriteLine("Die Summe ist: {0}",ersterSummandZahl + zweiterSummandZahl) ;
            Console.ReadKey();
        }
    }
}
