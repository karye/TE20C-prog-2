/* 
Raylib-projekt skapas med kommandona:
dotnet new console
dotnet add package raylib-cs
 */
using System;
using Raylib_cs;

namespace Shmup
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skapa fönstret
            Raylib.InitWindow(800, 600, "Raylib");
            Raylib.SetTargetFPS(60);
            
            // Skapar objekten
            Skepp spelare = new Skepp(@"resurser/space.png");
            
            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLACK);

                spelare.Uppdatera();
                spelare.Rita();
                
                Raylib.EndDrawing();
            }
        }
    }
}
