using System;
using Raylib_cs;

namespace JagaMonster_3
{
    public class Figur
    {
        int _x = 100;
        int _y = 100;
        Texture2D _textur;

        // Konstruktor nr 1
        public Figur(string bild, int x, int y)
        {
            _textur = Raylib.LoadTexture("./resurser/" + bild);
            _x = x;
            _y = y;
        }
        // Konstruktor nr 2 med slumpad startposition
        public Figur(string bild)
        {
            _textur = Raylib.LoadTexture("./resurser/" + bild);
            _x = Raylib.GetRandomValue(32, 512-30-32);
            _y = Raylib.GetRandomValue(32, 480-32-32);
        }

        // Rita ut metoden
        public void Rita()
        {
            // Rita ut bilden
            Raylib.DrawTexture(_textur, _x, _y, Color.WHITE);
        }
    }
}