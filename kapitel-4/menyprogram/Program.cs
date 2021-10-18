using System;

namespace menyprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enkelt menyprogram!");

            // skapa en slumpgenerator
            Random tärning = new Random();

            // program loop
            while (true)
            {
                // slumpa fram ett tal
                int Slumptal = tärning.Next(1,4);
            

                 Console.WriteLine("Välj ett av följande alternativ");
                 Console.WriteLine("Väljer du sten? (1)");
                 Console.WriteLine("Väljer du sax? (2)");
                 Console.WriteLine("Väljer du påse? (3)");
                 Console.WriteLine("vill du avsluta? (4)");
                 string valstring = Console.ReadLine();
                 
                 // vill användaren?
                 if (valstring == "4")
                 {
                     break;
                 }

                 int val = int.Prase(valSrting)

                 // är det rätt svar
                 if (val == )
                 {
                     Console.WriteLine("Du vinner");
                 }
                 else
                 {
                     Console.WriteLine("Du förlorar!");
                 }
            }

        }
    }
}
