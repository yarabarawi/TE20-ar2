using System;

namespace Uppgift_3._17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv in ett tal");
            int tal1 = int.Parse (Console.ReadLine());

            Console.WriteLine("skriv in ett tal");
            int tal2 = int.Parse (Console.ReadLine());

            Console.WriteLine("Välj ett räknesätt\n" + 
                            "1. Addition\n" +
                            "2. Subtraktion\n" +
                            "3. Multiplikation\n" +
                            "4. Division");

            string räknesätt = Console.ReadLine();
                       
            if (räknesätt == "1")
            {
                Console.WriteLine($"tal1 + tal2 = {tal1 + tal2}");
            }

            if (räknesätt == "2")
            {
                Console.WriteLine($"tal1 - tal2 = {tal1 - tal2}");
            }
            
            if (räknesätt == "3")
            {
             Console.WriteLine($"tal1 * tal2 = {tal1 * tal2}");
            }

             if (räknesätt == "4")
            {
             Console.WriteLine($"tal1 / tal2 = {tal1 / tal2}");
            }



            
        }
    }
}
