using System;

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

        // Detta fält är offentligt, så det kan användas från andra klasser
        public string name;

        // Konstruktorn för Tamagotchi-klassen
        public Tamagotchi(string name)
        {
            this.name = name;

            // Initiera fälten här
            this.hunger = 0;
            this.boredom = 0;
            this.words = new List<string>();
            this.isAlive = true;
            this.generator = new Random();
        }

        // Detta är en offentlig metod för att mata Tamagotchien
        public void Feed()
        {
            // Ändra hunger-fältet här
            this.hunger = 0;
        }

        // Detta är en offentlig metod för att hälsa på Tamagotchien
        public void Hi()
        {
            // Skriv ut en hälsning här
            Console.WriteLine("Hej, jag heter " + this.name);
        }

        // Detta är en offentlig metod för att lära Tamagotchien ett ord
        public void Teach(string word)
        {
            // Lägg till ordet i listan med ord
            this.words.Add(word);
        }

        // Detta är en offentlig metod för att uppdatera Tamagotchiens stats
        public void Tick()
        {
            // Ändra hunger- och boredom-fälten här
            this.hunger++;
            this.boredom++;

            if (this.hunger >= 10 || this.boredom >= 10)
            {
                // Ändra isAlive-fältet här
                this.isAlive = false;
            }

            // Anropa ReduceBoredom-metoden här
            ReduceBoredom();
        }

        // Detta är en offentlig metod för att skriva ut Tamagotchiens stats
        public void PrintStats()
        {
            // Skriv ut Tamagotchiens stats här
            Console.WriteLine("Hunger: " + this.hunger);
            Console.WriteLine("Boredom: " + this.boredom);
            Console.WriteLine("Words: " + string.Join(", ", this.words));
            Console.WriteLine("Is alive: " + this.isAlive);
        }

        // Detta är en offentlig metod för att kolla om Tamagotchien är vid liv
        public bool GetAlive()
        {
            // Returnera isAlive-fältet här
            return this.isAlive;
        }

        // Detta är en privat metod för att minska Tamagotchiens trötthet
        private void ReduceBoredom()
        {
            // Ändra boredom-fältet här
            this.boredom = Math.Max(0, this.boredom - 1);
        }

        // Detta är en privat metod för att få Tamagotchien att tala
        private void Speak()
        {
            // Skriv ut ett slumpat ord här
            Console.WriteLine(this.words[this.generator.Next(this.words.Count)]);
        }

        // Detta är en privat metod för att få Tamagotchien att leka
        private void Play()
        {
            // Ändra boredom-fältet här
            this.boredom = 0;
        }

        // Detta är en privat metod för att få Tamagotchien att sova
        private void Sleep()
        {
            // Ändra hunger-fältet här
            this.hunger = Math.Max(0, this.hunger - 1);
        }

        // Detta är en privat metod för att få Tamagotchien att äta
        private void Eat()
        {
            // Ändra hunger-fältet här
            this.hunger = 0;
        }

        // Detta är en privat metod för att få Tamagotchien att dö
        private void Die()
        {
            // Ändra isAlive-fältet här
            this.isAlive = false;
        }

    }