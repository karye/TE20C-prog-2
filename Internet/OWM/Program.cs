using System;
using System.Net;
using System.Text.Json;

namespace OWM
{
    // Mallen till det vi söker
    class Prognos 
    {
        public string name {get; set;}
        public int timezone {get; set;}
        public Main main {get; set;}
        public Wind wind {get; set;}
        public Weather[] weather {get; set;}
    }
    class Main
    {
        public double temp {get; set;}
    }
    class Wind
    {
        public double speed {get; set;}
    }
    class Weather
    {
        public string description {get; set;}
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hämta väder från OWM!");

            // Platsen
            string stad = "Göteborg";

            // Adressen till tjänsten
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={stad}&appid=22ee1d58f7adae08ee71fa7c0bd24481&units=metric&lang=se";

            // Steg 1: hämta från url
            WebClient klient = new WebClient();
            string json = klient.DownloadString(url);

            // Funkar det?
            //Console.WriteLine(json);

            // Steg 2: avkoda JSON
            Prognos objekt = JsonSerializer.Deserialize<Prognos>(json);

            // Skriv ut lite data
            Console.WriteLine(objekt.name);
            Console.WriteLine(objekt.timezone);
            Console.WriteLine(objekt.main.temp);
            Console.WriteLine(objekt.wind.speed);
            Console.WriteLine(objekt.weather[0].description);
        }
    }
}
