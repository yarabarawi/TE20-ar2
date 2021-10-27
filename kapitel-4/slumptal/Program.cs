using System;

namespace slumptal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Slumptal");

            // slump generator
            Random generator = new Random ();

            //slumpa fraam ett tal 1-10
            int slumptal = generator.Next(1,11);

            int slumptal2 = generator.Next(1,7);

            Console.WriteLine($"{slumptal} {slumptal2}");
        }
    }
}
