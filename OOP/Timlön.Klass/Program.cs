using System;

namespace Timlön.Klass
{
    // Mallen för flera objekt (pepparkaksformen)
    class Person
    {
        public string namn;
        public int timlön;
        public int arbetstid;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Räkan ut lönen!");

            // Skapa ett objekt för person1
            Person person1 = new Person();  // Instansiera ett objekt (Trycker ut en pepparkaka)

            Console.Write("Ange ditt namn: ");
            person1.namn = Console.ReadLine();
            Console.Write("Ange din timlön ");
            person1.timlön = int.Parse(Console.ReadLine());
            Console.Write("Ange din arbetstid: ");
            person1.arbetstid = int.Parse(Console.ReadLine());

            Person person2 = new Person();  // Ett till objekt
            Console.Write("Ange ditt namn: ");
            person2.namn = Console.ReadLine();
            Console.Write("Ange din timlön ");
            person2.timlön = int.Parse(Console.ReadLine());
            Console.Write("Ange din arbetstid: ");
            person2.arbetstid = int.Parse(Console.ReadLine());

            Person person3 = new Person();  // Ett till objekt
        }
    }
}
