using System;

namespace Char
{
    class Program
    {
        static void Main(string[] args)
        {
            string meddelande = "Hej på dig!"; 

            // skriv ut hela strängen
            Console.WriteLine(meddelande);

            // skriv ut första bokstaven 'H
            Console.WriteLine(meddelande[0]);

            // skriv ut sista tecknet '!'
            Console.WriteLine(meddelande[10]);

            char bokstav = 'Z';

            // Skriv ut alla tecken 
            for (int i = 11; i >= 0; i--)
            {
                 Console.WriteLine($"index {i} {meddelande[i]}");
            }

        }
    }
}
