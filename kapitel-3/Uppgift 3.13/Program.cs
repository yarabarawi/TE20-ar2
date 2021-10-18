using System;

namespace Uppgift_3._13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            string ålderString = Console.ReadLine();
            int ålder = int.Parse(ålderString);
            
            if (ålder >= 16 && ålder <= 19)
            {
                Console.WriteLine("Du får delta");
            }
            else
            {
                Console.WriteLine("Du får ej delta");
            }

            if (ålder < 16)
            {
                Console.WriteLine("Du är för ung");
            }

            if ( ålder> 19)
            {
                Console.WriteLine("Du är för gammal");
            }

            

        }
    }
}
