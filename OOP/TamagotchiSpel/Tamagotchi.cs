/* 
Klassdiagram
(+ betyder public, − betyder private)
Tamagotchi
− hunger: int
− boredom: int
− words: List<string>
− isAlive: bool
− generator: Random
+ name: string
+ Feed(): void
+ Hi(): void
+ Teach(word: string): void
+ Tick(): void
+ PrintStats(): void
+ GetAlive(): bool
− ReduceBoredom(): void
 */

using System;
using System.Collections.Generic;

namespace TamagotchiSpel
{
    class Tamagotchi
    {
        // Dessa fält är privata, så de kan bara användas inom klassen
        private int hunger;
        private int boredom;
        private List<string> words;
        private bool isAlive;
        private Random generator;

        // Dessa fält är publika, så de kan användas utanför klassen
        public string name;

        // Konstruktor
        public Tamagotchi(string name)
        {
            this.name = name;
            hunger = 0;
            boredom = 0;
            words = new List<string>();
            isAlive = true;
            generator = new Random();
        }

        // Metoder
        public void Feed()
        {
            hunger--;
        }

        public void Hi()
        {
            Console.WriteLine("Hej, jag heter " + name);
            boredom--;
            ReduceBoredom();
        }

        public void Teach(string word)
        {
            words.Add(word);
            boredom--;
            ReduceBoredom();
        }

        public void Tick()
        {
            hunger++;
            boredom++;
            if (hunger > 10 || boredom > 10)
            {
                isAlive = false;
            }
        }


        public void PrintStats()
        {
            Console.WriteLine("Hunger: " + hunger);
            Console.WriteLine("Boredom: " + boredom);
            Console.WriteLine("Words: " + string.Join(", ", words));
            Console.WriteLine("Alive: " + isAlive);
        }

        public bool GetAlive()
        {
            return isAlive;
        }

        private void ReduceBoredom()
        {
            if (boredom > 5)
            {
                int randomNumber = generator.Next(words.Count);
                Console.WriteLine(name + " learned the word " + words[randomNumber] + "!");
                words.RemoveAt(randomNumber);
                boredom = 0;
            }
        }

    }
}