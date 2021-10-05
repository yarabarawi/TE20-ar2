using System;

namespace kapitel_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Spel - gissa ett tal mellan 1 och 100.");

            // Slumpa fram ett Tal
            Random tärning = new Random();
            int slumptal = tärning.Next(1, 101);

            // Upprepa frågan
            int räknare = 0;
            while (true)
            {
                //räkna up antal gissningar = varv
                räknare++;

                // fråga användaren om en gissning
                Console.WriteLine("Gissa ett tal (1-100).");
                int gissning = int.Parse(Console.ReadLine());

                // är gissningen rätt?
                if (gissning == slumptal)
                {
                    Console.WriteLine($"Bra gissat!");
                    break;
                }

                //Jämnför med slumptal
                if (gissning < slumptal)
                {
                    Console.WriteLine("För lågt!");
                }
                else
                {
                    Console.WriteLine("För högt!");
                }
            }
        }
    }
}
