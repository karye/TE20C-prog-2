/* Lägg till en ny metod av typen bool som returnerar true
om personen är myndig (minst 18 år gammal).
För att räkna ut ålder kan du använda:
    int age = DateTime.Now.Year - birthday.Year
Avsluta med att skriva ihop ett exempel där du använder
klassen och visar att metoden Myndig() fungerar. */
using System;

namespace Uppgift_6
{
    class Elev
    {
        public string förnamn;
        public string efternamn;
        public DateTime födelseDatum;
        public int längd;
        public double vikt;

        public bool Myndig()
        {
            int ålder = DateTime.Now.Year - födelseDatum.Year;
            if (ålder >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }

            //return ålder >= 18;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
