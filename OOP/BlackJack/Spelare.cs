using System;
using System.Collections.Generic;

namespace BlackJack
{
    public class Spelare
    {
        // Interna variabler
        private string _namn;
        private List<Kort> _hand = new List<Kort>();
        private int _poäng;

        // Konstruktorn
        public Spelare(string namn)
        {
            _namn = namn;
        }

        // Metoderna
        // Spelaren tar emot ett draget kort
        public void TaEmotKort(Kort kort)
        {
            _hand.Add(kort);
            _poäng += kort.VärdeBlackJack();
        }

        // Summa av BlackJack-poängen för alla kort
        public virtual int Poäng()
        {
            return _poäng;
        }

        // Vilka kort finns i handen?
        public List<Kort> Hand()
        {
            return _hand;
        }
    }
}