using System;
using System.Net;
using System.Text.Json;

namespace APOD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dagens bild från Nasa");

            // Adressen till api-tjänsten
            string url = "https://api.nasa.gov/planetary/apod?api_key=DEMO_KEY";

            // Steg 1: hämta
            WebClient klient = new WebClient();
            string json = klient.DownloadString(url);

            // Steg 2: avkoda json-svaret
            Apod apod = new Apod();
            apod = JsonSerializer.Deserialize<Apod>(json);

            // Skriv svaret
            Console.WriteLine(apod.title);
        }

        // Matcha json
        class Apod
        {
            public string explanation {get; set;}
            public string title {get; set;}
            public string url {get; set;}
        }
    }
}
