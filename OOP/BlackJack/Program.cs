using System;
using System.Collections.Generic;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till Black Jack!");

            // Skapa spelaren och dealern
            Console.Write("Vad heter du? ");
            string namn = Console.ReadLine();
            Spelare spelare1 = new Spelare(namn);
            Dealer dealer = new Dealer();

            // Skapa en kortlek med 52 kort
            Kortlek kortlek = new Kortlek();
            kortlek.SkapaKortlek();

            // Blanda korten
            kortlek.BlandaKortlek();

            // Ge två kort till spelaren 
            Kort kort1 = kortlek.DraKort();
            Kort kort2 = kortlek.DraKort();
            spelare1.TaEmotKort(kort1);
            spelare1.TaEmotKort(kort2);

            Console.WriteLine("Du får två kort: ");
            Console.WriteLine("-" + kort1.TillText());
            Console.WriteLine("-"+ kort2.TillText());
            Console.WriteLine("Din poängsumma är " + spelare1.Poäng());

            // .. och två kort till dealern
            // Ett av dealerns kort ska vara öppet
            kort1 = kortlek.DraKort();
            kort2 = kortlek.DraKort();
            dealer.TaEmotKort(kort1);
            dealer.TaEmotKort(kort2);

            Console.WriteLine("Dealerns första kort är:");
            Console.WriteLine("-" + kort1.TillText());

            // Spelaren får välja att dra kort eller stanna. Om spelaren stannar, går turen vidare till dealern.
            
        }
    }
}
