using System;

namespace Student
{
    class Elev
    {
        public string förnamn;
        public string efternamn;
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

            Elev kalle = new Elev();
            kalle.förnamn = "Kalle";
            kalle.efternamn = "Karlsson";
        }
    }
}
