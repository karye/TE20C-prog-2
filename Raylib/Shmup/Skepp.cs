using System;
using System.Collections.Generic;
using Raylib_cs;

namespace Shmup
{
    public class Skepp
    {
        // Interna variablerna
        private Texture2D _bild;
        private Rectangle _hitbox;
        private int _antalLiv;
        private List<Skott> _skotten = new();           // Lista för skotten
        private Sound _skottLjud;

        // Konstruktor (ctor)
        public Skepp(string texturFil)
        {
            // Laddar in texturen
            _bild = Raylib.LoadTexture(texturFil);

            // Laddar in ett ljud (wav)
            _skottLjud = Raylib.LoadSound(@"resurser/...wav");

            _hitbox = new Rectangle(400, 300, _bild.width, _bild.height);
            _antalLiv = 3;
        }

        // Metod för att rita ut (func)
        public void Rita()
        {
            // Ritar ut själva skeppet
            Raylib.DrawTexture(_bild, (int)_hitbox.x, (int)_hitbox.y, Color.WHITE);

            // Ritar ut skeppets skott (flera)
            foreach (var skott in _skotten)
            {
                skott.Rita();
            }
        }

        // Styra skeppet
        public void Uppdatera()
        {
            if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
            {
                _hitbox.x -= 5;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
            {
                _hitbox.x += 5;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
            {
                _hitbox.y -= 5;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
            {
                _hitbox.y += 5;
            }

            // Se till att skeppet inte lämnar fönstret
            _hitbox.x = Math.Clamp(_hitbox.x, 0, 800 - _hitbox.width);
            _hitbox.y = Math.Clamp(_hitbox.y, 0, 600 - _hitbox.height);

            // Om man skjuter (mellanslag), rita ut färgad cirkel
            if (Raylib.IsKeyDown(KeyboardKey.KEY_SPACE))
            {
                // Skapa ett skott
                Skott skott = new Skott((int)_hitbox.x, (int)_hitbox.y);

                // Lägger till i listan
                _skotten.Add(skott);

                // Spela upp ljudet
                Raylib.PlaySound(_skottLjud);
            }

            // Uppdatera skotten
            foreach (var skott in _skotten)
            {
                skott.Uppdatera();
            }
        }
    }
}