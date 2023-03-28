using System;

namespace BlackJack
{
    // Dealer ärver allt från Spelare
    public class Dealer : Spelare // Arv
    {
        // Konstruktorn
        public Dealer() : base("Dealer")
        {
        }

        // Berätta vad är första kortet
        public Kort FörstaKort()
        {
            return Hand()[0];
        }

        // Räkna ut poäng som för spelare
        // Utom att Ess = 11
        public override int Poäng()
        {
            int poäng = 0;
            foreach (var kort in Hand())
            {
                if (kort.VärdeBlackJack() == 11 && poäng + 11 > 21)
                {
                    poäng += 1;
                }
                else
                {
                    poäng += kort.VärdeBlackJack();
                }
            }
            return poäng;
        }
    }
}