using System;

namespace BoolskaOperationer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coronasymptom!");

            System.Console.WriteLine("Har du feber? ja/nej");
            string feber = Console.ReadLine();

            System.Console.WriteLine("Hostar du? ja/nej");
            string hosta = Console.ReadLine();

            System.Console.WriteLine("Har du tappat smaken? ja/nej");
            string smak = Console.ReadLine();

            System.Console.WriteLine("Är du vaccinerad mot covid? ja/nej");
            string vaccin = Console.ReadLine();

            // om dessa tre vilkor är uppfylda (&& betyder och)
            if (hosta == "ja" && smak == "ja")
            {
                System.Console.WriteLine(" Du har tydligen covid");
            }

            if (feber == "ja" && smak == "ja")
            {
                Console.WriteLine("Du har troligen covid");
            }

            if (feber == "ja" || hosta == "ja" && smak == "ja")
            {
                Console.WriteLine("Du har troligen covid");
            }
            
        }
    }
}
