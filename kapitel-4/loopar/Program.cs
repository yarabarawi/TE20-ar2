using System;

namespace loopar
{
    class Program
    {
        static void Main(string[] args)
        {
           
           int summa = 0;
           for (var i = 1; i < 11; i++)
           {
               summa += i;
           }
           Console.WriteLine($"summa är {summa}");

           string namn = "Ali"; 

           // skriv ut andra bokstaven
           Console.WriteLine(namn[0]);
           Console.WriteLine(namn[1]);
           Console.WriteLine(namn[3]);
           Console.WriteLine(namn[4]);
           
           for (var i = 7; i > -1; i--)
           {
               Console.WriteLine(namn [1]);
           }
           

        }
    }
}
