using System;

namespace uppgift_1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vad är lönen för person 1?");
            int lön1 = int.Parse(Console.ReadLine());

            Console.WriteLine("vad är lönen för person 2");
            int lön2 = int.Parse(Console.ReadLine());

            Console.WriteLine("vad är lönen för person 3");
            int lön3 = int.Parse(Console.ReadLine());

            float medelvärde = (lön1 + lön2 + lön3) / 3;

            Console.WriteLine($"Medelvärdet är {medelvärde}");


            //          System.Console.WriteLine($"{lön} gammal");

            // Konvertera från string till heltal
            //          int ålderTal = int.Parse(lön);

            //          Console.WriteLine($"du har {20-ålderTal} år kvar tills du får gå på systemet");
            //       
            //           Console.WriteLine("Hur mycket väger du?");
            //           float vikt = float.Parse(Console.ReadLine());

            //           Console.WriteLine($"Din vikt blir {vikt * 2.2} lbs"); 






        }
    }
}
