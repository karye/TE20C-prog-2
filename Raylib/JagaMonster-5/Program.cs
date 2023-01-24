using System;
using Raylib_cs;

namespace JagaMonster_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(512, 480, "Raylib");
            Raylib.SetTargetFPS(60);

            // Skapa bakgrunden
            Figur bakgrund = new Figur("background.png", 0, 0);
            
            // Skapa ett monster mha klassen Figur
            Figur monster = new Figur("monster.png");

            // Skapa en hjälte
            Hjälte hero = new Hjälte("hero.png");
            
            while (!Raylib.WindowShouldClose())
            {
                // Uppdatera objekten
                hero.Uppdatera();

                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.DARKGREEN);

                // Rita ut bakgrunden
                bakgrund.Rita();

                // Rita ut monstret
                monster.Rita();

                // Rita ut hjälten
                hero.Rita();
                
                Raylib.EndDrawing();
            }
        }
    }
}
