using System;
using Raylib_cs;

namespace Shmup
{
    public class Skott
    {
        // Interna variabler
        private Rectangle _hitbox;
        
        // Metoderna
        // Konstruktorn tar emot skeppets x & y
        public Skott(int x, int y)
        {
            _hitbox.x = x;
            _hitbox.y = y;
        }

        // Ritar ut skottet
        public void Rita()
        {
            Raylib.DrawCircle((int)_hitbox.x + 32, (int)_hitbox.y - 15, 20, Color.YELLOW);
        }

        // Skottets rörelse
        public void Uppdatera()
        {
            _hitbox.y -= 10;
        }
    }
}