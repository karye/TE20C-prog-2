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

            // Hur månfa finns det?
            foreach (var kort in kortlek.GeKortlek())
            {
                Console.WriteLine(kort.TillText());
            }
        }
    }
}
