using System;

namespace Student
{
    class Elev
    {
        public string förnamn;
        public string efternamn;
        public DateTime födelseDatum;
        public int längd;
        public double vikt;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Skapa en klass som heter Elev 
            // Med två interna variabler: förnamn & efternam
            // Skapa två objekt från klassen Elev
            // Och fyll objekten med något vettigt

            Elev linus = new Elev();
            linus.förnamn = "Linus";
            linus.efternamn = "Strindin";
            linus.födelseDatum = new DateTime(1979, 2, 29);
            linus.längd = 180;
            linus.vikt = 3;

            Elev kalle = new Elev();
            kalle.förnamn = "Kalle";
            kalle.efternamn = "Karlsson";
            kalle.födelseDatum = new DateTime(1989, 10, 15);
            kalle.längd = 175;
            kalle.vikt = 65;
        }
    }
}
