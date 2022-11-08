using System;
using System.IO;
using System.Text.Json;

namespace HighScore
{
    // Mall för att lagra information
    class SpelarePoäng
    {
        public string namn {get; set;}
        public int poäng {get; set;}
        public DateTime datum {get; set;}
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Highscore!");

            // Skapa (new) ett objekt utifrån klassen
            SpelarePoäng spelare = new SpelarePoäng();

            // Fylla objektet med information
            spelare.namn = "Kim";
            spelare.poäng = 190;
            spelare.datum = DateTime.Now;

            // Spara i fil
            //File.WriteAllText("highscore.txt", $"{spelare.namn} {spelare.poäng} {spelare.datum}");

            // Spara i JSON-format
            // Steg 1 - generara JSON-text
            string JSONText = JsonSerializer.Serialize(spelare);
            //Console.WriteLine(JSONText);
            File.WriteAllText("highscore.json", JSONText);
        }
    }
}
