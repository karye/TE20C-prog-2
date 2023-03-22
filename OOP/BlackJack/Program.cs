using System;
using System.Collections.Generic;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till Black Jack!");

            // Testa kortleken
            // 1. Skapa en tom kortlek
            Kortlek kortlek = new Kortlek();

            // 2. Fyll med kort
            kortlek.SkapaKortlek();

            // 3. Blanda korten
            kortlek.BlandaKortlek();

            // Dra ett kort
            Kort kort = kortlek.DraKort();
            Console.WriteLine(kort.TillText());

            // Skapa en spelare
            Spelare spelaren = new Spelare("Kalle");

            // Ge spelare kortet som vi dragit
            spelaren.TaEmotKort(kort);

            // Hur många poäng har spelaren?
            Console.WriteLine($"{spelaren.Poäng()} poäng");
        }
    }
}
