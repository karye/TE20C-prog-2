using System;
using Raylib_cs;

namespace JagaMonster_5
{
    public class Figur
    {
        int _x = 100;
        int _y = 100;
        int _vx = 1;
        int _vy = 1;
        Texture2D _textur;

        // Konstruktor nr 1 (ctor)
        public Figur(string bild, int x, int y)
        {
            _textur = Raylib.LoadTexture("./resurser/" + bild);
            _x = x;
            _y = y;
        }

        // Konstruktor nr 2 med slumpad startposition (ctor)
        public Figur(string bild)
        {
            _textur = Raylib.LoadTexture("./resurser/" + bild);
            _x = Raylib.GetRandomValue(32, 512-30-32);
            _y = Raylib.GetRandomValue(32, 480-32-32);
            _vx = 0;
            _vy = Raylib.GetRandomValue(1, 10);
        }

        // Rita ut metoden (func)
        public void Rita()
        {
            // Rita ut bilden
            Raylib.DrawTexture(_textur, _x, _y, Color.WHITE);
        }

        // Ändra position (func)
        public void Updatera()
        {
            // Horisontell
            _x += _vx;

            // Om figuren når högerkanten börja om
            if (_x > 512-30-32)
            {
                _x = 30;
            }

            // Vertikal
            _y += _vy;

            // Om figuren når nederkanten börja om
            if (_y > 480-32-32)
            {
                _y = 0;
            }
        }
    }
}