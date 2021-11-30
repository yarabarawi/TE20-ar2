using System;

namespace tryparse
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Slump generator
            Random generator = new Random();
            // slumpa fram ett tal mellan 1-100
            int slumptal = generator.Next(1,101);
            int slumpta2 = generator.Next(1,11);

            // be spelaren gissa ett tal 
            //Console.Write("gissa ett tal (1-100)");
            //string gissning = Console.ReadLine();

            //försök översätta det inmatade till ett tal
            int gissningTal = 0;
            bool korrekt = false;

            // loop för att tvinga spelaren att mata in något korrekt
            while (korrekt != true)
            {
                Console.WriteLine("Du måste mata in ett tal (1-100)");
                string gissning = Console.ReadLine();
                korrekt = int.TryParse(gissning, out gissningTal);
            
           

            // var gissningen correct
            if (gissningTal == slumptal)
            {
                Console.WriteLine("du gisssa rätt");
            }
            else
            {
                Console.WriteLine("Du gissa fel");
            }
            }


        }
    }
}
