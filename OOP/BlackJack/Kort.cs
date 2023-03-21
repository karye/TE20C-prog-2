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
        // Kortets värde 1(Ess), 2-10, 11 (Knekt), 12 (Dam), 13 (Kung)
        private int _värde;

        // Kortets färg: hjärter, ruter, spader, klöver
        private Färgtyp _färg;

        // Metoderna
        // Konstruktor: den som skapar själva kortet
        public Kort(int värde, Färgtyp färg)
        {
            _värde = värde;
            _färg = färg;
        }

        // Ge ut Black Jack värdet
        public int VärdeBlackJack()
        {
            // Om Ess = 1 eller 11
            // 2-10 = 2-10
            // Kk, D, K = 10

            switch (_värde)
            {
                case 1:         // Ess 1 @TODO kan vara 11
                    return 1;   
                case 11:        // Knekt
                    return 10;  
                case 12:        // Dam
                    return 10;  
                case 13:        // Kung
                    return 10;  
                default:        // 2-10
                    return _värde;
            }
        }

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