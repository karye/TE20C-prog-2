using System;
using Raylib_cs;

namespace MoonLander_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(800, 600, "MoonLander");
            Raylib.SetTargetFPS(60);
            
            // Skapa objekten på höjd=600 m med hastighet=0 m/s
            Landare landare = new Landare(400, 0, "resurser/lander.png", 600, 0.5f);

            while (!Raylib.WindowShouldClose())
            {
                // Uppdaterar objekten
                landare.Faller();

                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLACK);

                // Ritar ut objekten
                landare.RitaKontrollpanel();
                landare.Rita();
                
                Raylib.EndDrawing();
            }
        }
    }
}
