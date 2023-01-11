using System;
using Raylib_cs;

namespace JagaMonster_2
{
    public class Figur
    {
        int _x = 100;
        int _y = 100;
        Texture2D _textur;

        // Konstruktor
        public Figur(string bild, int x, int y)
        {
            _textur = Raylib.LoadTexture("./resurser/" + bild);
            _x = x;
            _y = y;
        }

        // Rita ut metoden
        public void Rita()
        {
            // Rita ut bilden
            Raylib.DrawTexture(_textur, _x, _y, Color.WHITE);
        }
    }
}