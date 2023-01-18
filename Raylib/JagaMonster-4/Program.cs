using System;
using System.Collections.Generic;
using Raylib_cs;

namespace JagaMonster_4
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

            // Skapa 100 monster
            List<Figur> listaMonster = new List<Figur>();
            for (int i = 0; i < 100; i++)
            {
                listaMonster.Add(new Figur("monster.png"));
            }
            
            while (!Raylib.WindowShouldClose())
            {
                /* Upddatera saker */
                hero.Update();
                foreach (var monster in listaMonster)
                {
                    monster.Update();
                }

                /* Rita ut saker */
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);

                // Rita ut objektet
                bakgrund.Rita();
                hero.Rita();

                // Rita ut 100 monster
                foreach (var monster in listaMonster)
                {
                    monster.Rita();
                }
                
                Raylib.EndDrawing();
            }
        }
    }
}
