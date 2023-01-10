using System;
using Raylib_cs;

namespace JagaMonster_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Raylib!");

            // Skapa ett fönster
            Raylib.InitWindow(512, 480, "Jaga Monster");
            Raylib.SetTargetFPS(60);

            // Skapa objekt
            Figur hero = new Figur("hero.png", 100, 100);
            Figur monster = new Figur("monster.png", 100, 200);
            Figur hus = new Figur("house.png", 300, 350);
            Figur damm = new Figur("pond.png", 400, 100);

            // Speloopen
            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.DARKGREEN);

                // Rita ut här
                hero.Rita();
                monster.Rita();
                hus.Rita();
                damm.Rita();

                Raylib.EndDrawing();
            }
        }
    }
}
