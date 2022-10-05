using System;
using System.Net;
using System.Text.Json;

namespace ChuckNorris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hämta ett Chuck Norris skämt!");

            // Adressen till api-tjänsten
            string url = "https://api.chucknorris.io/jokes/random";

            // Verktyg för att hämta data från Internet
            WebClient klient = new WebClient();

            // Utför anropet
            string json = klient.DownloadString(url);

            //Console.WriteLine(json);

            // Avkoda JSON
            // Skapa ett objekt 
            Skämt skämtet = new Skämt();
            skämtet = JsonSerializer.Deserialize<Skämt>(json);

            // Skriv ut vad vi hittade
            Console.WriteLine(skämtet.value);
            Console.WriteLine(skämtet.icon_url);
        }

        // För att matcha innehållet i objektet json
        class Skämt
        {
            public string icon_url {get; set;}
            public string value {get; set;}
        }
    }
}
