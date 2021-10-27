using System;

namespace lyckohjul
{
    class Program
    {
        static void Main(string[] args)
        {

            // Skapa ett program som ska fungera som ett lyckohjul
            Console.WriteLine("lyckohjul");
            Random generator = new Random();

            //När användaren kör programmet får hen välja ett tal från 1 till 10 som hen tror att lyckohjulet kommer att stanna på

            // Slumpa därefter fram ett tal från 1 till 10 och säg till användaren vilket tal det blev
            int slumptal = generator.Next(1, 11);

            // Berätta också för användaren om hen vann eller förlorade


            for (var i = 0; i < 3; i++)
            {
                Console.WriteLine("välj ett tal mellan 1-10");
                int gissning = int.Parse(Console.ReadLine());
                if (slumptal == gissning)
                {
                    Console.WriteLine("du vann");
                    break;
                }
                else
                {
                    Console.WriteLine("du förlora");
                }
            }




        }
    }
}
