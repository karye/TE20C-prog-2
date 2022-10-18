using System;

namespace Timlön
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Räkna ut timlön för anställda");

            // person1.namn
            // Ange namn
            Console.Write("Ange ditt namn: ");
            string namn1 = Console.ReadLine();
            
            // Ange din person1.timlön
            Console.Write("Ange din timlön: ");
            int timlön1 = int.Parse(Console.ReadLine());

            // Ange din totala person1.arbetstid
            Console.Write("Ange din arbetstid: ");
            int arbetstid1 = int.Parse(Console.ReadLine());

            // Räkna ut inkomsten
            Console.WriteLine($"{namn1} din lön blir {timlön1 * arbetstid1}");

            // Person 2
            // Ange person2.namn
            Console.Write("Ange ditt namn: ");
            string namn2 = Console.ReadLine();
            
            // Ange din person2.timlön
            Console.Write("Ange din timlön: ");
            int timlön2 = int.Parse(Console.ReadLine());

            // Ange din totala person2.arbetstid
            Console.Write("Ange din arbetstid: ");
            int arbetstid2 = int.Parse(Console.ReadLine());

            // Räkna ut inkomsten
            Console.WriteLine($"{namn2} din lön blir {timlön2 * arbetstid2}");

            // Person 3
            // Ange person3.namn
            Console.Write("Ange ditt namn: ");
            string namn3 = Console.ReadLine();
            
            // Ange din person3.timlön
            Console.Write("Ange din timlön: ");
            int timlön3 = int.Parse(Console.ReadLine());

            // Ange din totala person3.arbetstid
            Console.Write("Ange din arbetstid: ");
            int arbetstid3 = int.Parse(Console.ReadLine());

            // Räkna ut inkomsten
            Console.WriteLine($"{namn3} din lön blir {timlön3 * arbetstid3}");


        }
    }
}
