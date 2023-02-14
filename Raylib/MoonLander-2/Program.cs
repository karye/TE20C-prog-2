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

            while (!Raylib.WindowShouldClose())
            {
                // Uppdaterar objekten
                landare.Faller(20);

                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLACK);
                Raylib.DrawRectangle(0, 575, 800, 25, Color.GRAY);

                // Ritar ut objekten
                landare.RitaKontrollpanel();
                landare.Rita();
                
                Raylib.EndDrawing();
            }
        }
    }
}
