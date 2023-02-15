using System;
using Raylib_cs;

namespace MoonLander_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(800, 600, "MoonLander");
            Raylib.SetTargetFPS(60);
            
            // Skapa objekten på höjd=600 m med hastighet=0 m/s
            Landare landare = new Landare(400, 0, "resurser/lander.png", 600, 0.5f);

            // Skapa ett objekt
            Himlakropp jorden = new Himlakropp(650, 100, "./resurser/planet-earth.png");
            Himlakropp bakgrund = new Himlakropp(0, 0, "./resurser/dario-bronnimann-0bnWLAbAO64-unsplash.png");

            while (!Raylib.WindowShouldClose())
            {
                // Uppdaterar objekten
                landare.Faller(20);

                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLACK);

                // Ritar ut stjärnor i bakgrunden
                bakgrund.Rita();

                // Månytan
                Raylib.DrawRectangle(0, 575, 800, 25, Color.GRAY);

                // Rita annat
                jorden.Rita();
                landare.RitaKontrollpanel();
                landare.Rita();
                
                Raylib.EndDrawing();
            }
        }
    }
}
