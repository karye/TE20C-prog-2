using System;
using Raylib_cs;
using System.Numerics;

namespace MoonLander_1
{
    public class Landare
    {
        // Egenskaper
        private Texture2D _textur; // Bilden 
        private Vector2 _position; // position
        private float _höjd;       // Höjden ovan månens yta
        private float _hastighet;  // Hur snabbt den faller i y-led

        // Konstruktor för att skapa landaren med startvärden
        public Landare(int x, int y, string texturfil, float höjd, float hastighet)
        {
            _position.X = x;
            _position.Y = y;
            _textur = Raylib.LoadTexture(texturfil);
            _höjd = höjd;
            _hastighet = hastighet;
        }

        // Metod för att rita ut
        public void Rita()
        {
            Raylib.DrawTexture(_textur, (int)_position.X, (int)_position.Y, Color.WHITE);
        }

        // Metod för att simulera mångravitationen
        public void Faller()
        {
            // Minskar höjden när den faller
            _höjd -= _hastighet;

            // Hastigheten skall öka pga acceleration gravitationen
            _hastighet += 0.01f;

            _position.Y = 600 - _höjd - _textur.height;
        }

        // Skriva ut höjd & hastighet
        public void RitaKontrollpanel()
        {
            Raylib.DrawText($"Höjd: {_höjd:0} m", 10, 10, 20, Color.WHITE);
            Raylib.DrawText($"Hastighet: {_hastighet:0.0} m/s", 10, 40, 20, Color.WHITE);
        }
    }
}