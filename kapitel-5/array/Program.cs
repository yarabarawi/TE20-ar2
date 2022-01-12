using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Använda array!");

            // skapa en array fö 3 öar

            string[] öar = new string[3];
            // första platsen (0)
            öar[0] = "syros";
            öar[1] = "naxos";
            öar[2] = "kreta";

            //byt ut innehållet
            öar[0] = "Amorgos";

            //skriv ut innehållet
            Console.WriteLine(öar[0]);
            Console.WriteLine($"Två andra öar är {öar[1]} och {öar[2]}");
        }
    }
}
