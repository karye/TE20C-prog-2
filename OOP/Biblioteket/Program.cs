﻿using System;
using System.Collections.Generic;

namespace Biblioteket
{
    class Boklån
    {
        // Klassens interna variabler
        public string bok;
        public string låntagare;
        public DateTime datum;

        // Klassens metoder
        // När skall boken lämnas tillbaka?
        public DateTime LämnasTillbaka()
        {
            return datum.AddDays(30);
        }

        // Hur många dagar kvar på boklånet?
        public int DagarKvar()
        {
            return (int)(LämnasTillbaka() - DateTime.Now).TotalDays;
        }

        // Skriv ut all låneinformation
        public void SkrivUt()
        {
            Console.WriteLine($"Bokens namn: {bok}");
            Console.WriteLine($"Bokens låntagare: {låntagare}");
            Console.WriteLine($"Boken lämnas tillbaka {LämnasTillbaka()}");
            Console.WriteLine($"Boken har {DagarKvar()} dagar kvar på lånet");
        }

        // Förläg ett lån
        public void FörlängLån()
        {
            datum.AddDays(30);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello biblioteket!");

            // Lista för att regitrera lån av böcker
            List<Boklån> listaLån = new List<Boklån>();

            // Programloop
            while (true)
            {
                // Mata in lånet uppgifter
                Console.Write("Ange bokens namn: ");
                string bokNamn = Console.ReadLine();
                Console.Write("Ange låntagarens namn: ");
                string låntagarensNamn = Console.ReadLine();
                DateTime låneDatum = DateTime.Now;

                // Ett objekt från klassen Boklån
                Boklån lån = new Boklån();
                lån.bok = bokNamn;
                lån.låntagare = låntagarensNamn;
                lån.datum = låneDatum;

                // Spara lånet i listan
                listaLån.Add(lån);

                // Avsluta inmatning
                Console.WriteLine("Vill du mata in ett till lån (j/n)");
                string svar = Console.ReadLine();
                if (svar == "n")
                {
                    break;
                }
            }

            // Skriv ut alla lån
            foreach (var lån in listaLån)
            {
                lån.SkrivUt();
            }
        }
    }
}