using System;
using System.Numerics;
using Raylib_cs;

namespace MoonLander_2
{
    public class Himlakropp
    {
        private Vector2 _position;
        private Texture2D _textur;

        // Konstruktor = ctor
        public Himlakropp(int x, int y, string texturFil)
        {
            _position.X = x;
            _position.Y = y;
            _textur = Raylib.LoadTexture(texturFil);
        }

        // Vanlig metod = func
        public void Rita()
        {
            Raylib.DrawTexture(_textur, (int)_position.X, (int)_position.Y, Color.WHITE);
        }
    }
}