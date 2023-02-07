using System;
using System.Numerics;
using Raylib_cs;

namespace JagaMonster_5
{
    public class Hjälte
    {
        int _x = 0;
        int _y = 0;
        Texture2D _textur;
        Vector2 _förflyttning;

        // Konstruktor (ctor)
        public Hjälte(string bild)
        {
            _textur = Raylib.LoadTexture("./resurser/" + bild);
        }

        // Rita ut metoden (func)
        public void Rita()
        {
            // Rita ut bilden
            Raylib.DrawTexture(_textur, _x, _y, Color.WHITE);
        }

        // Ändra position mha piltangenterna
        public void Uppdatera()
        {
            // Nollställ förflyttningsvektor
            _förflyttning = Vector2.Zero;

            // Lyssna på tangenter
            // Om pil vänster/höger/upp/ned då flytta
            if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
            {
                _förflyttning.X -= 1;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
            {
                _förflyttning.X += 1;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
            {
                _förflyttning.Y -= 1;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
            {
                _förflyttning.Y += 1;
            }

            // Flytta!
            _x += (int)_förflyttning.X;
            _y += (int)_förflyttning.Y;
        }
    }
}