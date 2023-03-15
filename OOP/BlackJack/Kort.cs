using System;

namespace BlackJack
{
    // En lista av värde som vi tycker är användbara
    public enum Färgtyp
    {
        hjärter, ruter, spader, klöver
    }

    /// <summary>
    /// Beskriver ett enskilt kort
    /// </summary>
    public class Kort
    {
        // Interna variablerna
        // Kortets värde
        private int _värde;
        // Kortets färg: hjärter, ruter, spader, klöver
        private Färgtyp _färg;
        // Kortets värde i Black Jack
        private int _värdeBlackJack;

        // Metoderna
        // Konstruktor: den som skapar själva kortet
        public Kort(int värde, Färgtyp färg)
        {
            _värde = värde;
            _färg = färg;
        }

        // Ge ut Black Jack värdet
/*         public int VärdeBlackJack()
        {
            return värde;
        } */

        // Kortets värde och färg som text
        public string TillText()
        {
            string kortText = "";

            if (_värde == 1)
            {
                kortText = "Ess";
            }
            else if (_värde == 11)
            {
                kortText = "Knekt";
            }
            else if (_värde == 12)
            {
                kortText = "Dam";
            }
            else if (_värde == 13)
            {
                kortText = "Kung";
            }
            else
            {
                kortText = _värde.ToString();
            }
            return kortText;
        }
    }
}