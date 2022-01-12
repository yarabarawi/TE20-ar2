using System;

namespace split
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Räkna ord");

            Console.WriteLine("ange en mening:");
            string mening = Console.ReadLine();

            // Dela upp för att hitta alla ord på varsin rad
            // split = sax
            string[] orden = mening.Split(' ');

            // skriv ut alla ord på varsin rad
            foreach (var ord in orden)
            {
                Console.WriteLine(ord);
            }

            //hur många ord finns det i arrayan
            Console.WriteLine($"Antal ord i en mening är {orden.Length}");

            // sätt samman en ny mening
            string nyMening = string.Join('/', orden);

            // skriv ut meningen
            Console.WriteLine(nyMening);

        }
    }
}
