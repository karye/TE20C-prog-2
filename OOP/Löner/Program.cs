using System;
using System.Collections.Generic;

namespace Löner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Löneprogram!");

            // Vi skapar en samling för att spara "korten"
            List<PersonInkomst> listaAnställda = new List<PersonInkomst>();

            // Programloop
            while (true)
            {
                // Skapar ett objekt som heter anställd
                PersonInkomst anställd = new PersonInkomst();

                // Inmatning
                Console.Write("Ange namn: ");
                anställd.namn = Console.ReadLine();
                Console.Write("Ange timlön: ");
                anställd.timlön = int.Parse(Console.ReadLine());
                Console.Write("Ange timmar: ");
                anställd.timmar = int.Parse(Console.ReadLine());

                // Spara i listan
                listaAnställda.Add(anställd);

                Console.Write("Vill du registrera en till? (j/n) ");
                string svar = Console.ReadLine();
                if (svar == "n")
                {
                    break;
                }
            }

            // Skriv ut sammanställning
            int totalLön = 0;
            foreach (var anställd in listaAnställda)
            {
                Console.WriteLine($"Anställd {anställd.namn} får lön {anställd.Lön()}");
                totalLön += anställd.Lön();
            }
            Console.WriteLine($"Totala lönekostnaden är {totalLön}");

        }
    }
}
