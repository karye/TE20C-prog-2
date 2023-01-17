using System;
using System.Collections.Generic;
using Raylib_cs;

namespace JagaMonster_3
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
            //Figur monster = new Figur("monster.png");

            // Skapa ett till monster på slumpad position!
            //Figur monster2 = new Figur("monster.png");

            // Skapa 100 monster
            List<Figur> listaMonster = new List<Figur>();
            for (int i = 0; i < 100; i++)
            {
                listaMonster.Add(new Figur("monster.png"));
            }
            
            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);

                // Rita ut objektet
                bakgrund.Rita();
                hero.Rita();
                //monster.Rita();
                //monster2.Rita();

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
