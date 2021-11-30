using System;

namespace TP_frågor__array_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Slumpa fram en fråga");

            // namnge korten (arrray)
            string[] korten = {
                "När uppfördes verdi?",
                "Vem vann fotbolls-EM 1984?",
                "Vem skrev frankenstein?",
                "vad blir 5+5",
                "vem är president i USA 2021"
            };

            // Kasta tärning
            Random tärning = new Random();
            int Slumptal = tärning.Next(0, 6); // 0-5

            // skriver utslaget
            Console.WriteLine($"Tärningen slog {Slumptal}");

            //Skriv ut en fråga 
            Console.WriteLine($"Fråga : {korten[Slumptal]}");
        }
    }
}
