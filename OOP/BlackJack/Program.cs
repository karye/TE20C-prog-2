using System;
using System.Collections.Generic;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till Black Jack!");

            // Testa att skapa ett kort
            Kort hjärterFem = new Kort(5, Färgtyp.hjärter);
            Kort hjärterNio = new Kort(9, Färgtyp.hjärter);

            // Samla Kort i en List
            List<Kort> hand = new List<Kort>();
            hand.Add(hjärterFem);
            hand.Add(hjärterNio);

            // Skriva ut poängen
            // För varje kort
            foreach (var kort in hand)
            {
                Console.WriteLine($"Kortets värde är: {kort.TillText()}");
            }
        }
    }
}
