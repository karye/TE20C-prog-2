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
            // Fyller på med alla hjärterkort
            for (int i = 1; i < 14; i++)    // 1, 2, 3 .. 13
            {
                // Skapa kortet
                Kort kortet = new Kort(i, Färgtyp.hjärter);

                // Lägga till i kortleken
                _korten.Add(kortet);

                // Skapa kortet
                kortet = new Kort(i, Färgtyp.ruter);

                // Lägga till i kortleken
                _korten.Add(kortet);

                // Skapa kortet
                kortet = new Kort(i, Färgtyp.spader);

                // Lägga till i kortleken
                _korten.Add(kortet);

                // Skapa kortet
                kortet = new Kort(i, Färgtyp.klöver);

                // Lägga till i kortleken
                _korten.Add(kortet);
            }
        }

        // Blanda kortleken
        public void BlandaKortlek()
        {
            // För att slumpa
            Random generator = new Random();

            // Gå igenom alla 52 kort
            // Och slumpmässigt lägga tillbaka dem
            for (int i = 0; i < _korten.Count; i++)
            {
                // Slumpa en position
                int index = generator.Next(0, _korten.Count);

                // Plocka ut ett kort
                Kort kortTemporär = _korten[i];

                // Dra ett slumpmässigt kort
                _korten[i] = _korten[index];

                // Lägg tillbaka första kortet
                _korten[index] = kortTemporär;
            }

        }

        // Dra ett kort ur högen
        public Kort DraKort()
        {
            // Dra kortet överst
            Kort kortet = _korten[0];

            // Ta bort kortet
            _korten.RemoveAt(0);

            return kortet;
        }
    }
}