using System;
using Raylib_cs;

namespace JagaMonster_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(512, 480, "Raylib");
            Raylib.SetTargetFPS(60);
            
            // Skapa ett objekt
            Figur hero = new Figur("hero.png", 100, 100);
            Figur bakgrund = new Figur("background.png", 0, 0);

            // Skapa ett monster på slumpad position!
            Random generator = new Random();
            int x = generator.Next(32, 512-30-32);
            int y = generator.Next(32, 480-32-32);
            Figur monster = new Figur("monster.png", x, y);
            
            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);

                // Rita ut objektet
                bakgrund.Rita();
                hero.Rita();
                monster.Rita();
                
                Raylib.EndDrawing();
            }
        }
    }
}
