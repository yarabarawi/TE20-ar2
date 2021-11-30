using System;

namespace Uppgift_4._11
{
    class Program
    {
        static void Main(string[] args)
        {



            for (var i = 1; i < 6; i++)
            {

                Console.WriteLine("Vilket är Europas folkrikaste land?");
                string svar = Console.ReadLine();

                if (svar == "Ryssland" || svar == "ryssland")
                {
                    Console.WriteLine("Helt rätt bra jobbat!");
                    break;
                }
                else
                {
                    Console.WriteLine("Försök igen");
                }
            }
        }
    }
}
