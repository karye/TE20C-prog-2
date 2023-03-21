using System;
using System.Collections.Generic;

namespace BlackJack
{
    public class Kortlek
    {
        // Alla kort (tom)
        private List<Kort> _korten = new List<Kort>();

        // Ge en ut en kopia
        public List<Kort> GeKortlek()
        {
            return _korten;
        }
        
        // Fylla kortleken med alla 52 kort
        public void SkapaKortlek()
        {
            for (int i = 1; i < 14; i++)    // 1, 2, 3 .. 13
            {
                // Skapa kortet
                Kort kortet = new Kort(i, Färgtyp.hjärter);

                // Lägga till i kortleken
                _korten.Add(kortet);
            }
        }

        // Blanda kortleken
        public void BlandaKortlek()
        {
            
        }
    }
}