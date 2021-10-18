using System;

namespace Uppgift_2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vad heter du? ");
            string namn = Console.ReadLine();

            Console.Write("Hur gammal är du? ");
            string ålder = Console.ReadLine();

            Console.WriteLine("Hej " + namn + ", Din ålder är " + ålder);

            Console.Write("Har du syskon? (j/n)");
            string svar = Console.ReadLine();

            if (svar == "j")
            {
                Console.WriteLine("bra");
            }
            else
            {
               Console.WriteLine("bra ändå");
            }


        }
    }
}
