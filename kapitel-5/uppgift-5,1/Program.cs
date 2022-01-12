using System;

namespace uppgift_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Använda array!");

            // skapa en array fö 3  svenska städer

            string[] städer = new string[3];
            // första platsen (0)
            städer[0] = "sthlm";
            städer[1] = "gbg";

            //låt användaren skriva in namnet på den tredje stadem
            Console.WriteLine("skriv ett namn på en svensk namn");
            städer[2] = Console.ReadLine();

            // skriv avslutningsvis ut alla stdsnamnen på samma rad
            Console.WriteLine($"{städer[0]}, {städer[1]}, {städer[2]}");
        }
    }
