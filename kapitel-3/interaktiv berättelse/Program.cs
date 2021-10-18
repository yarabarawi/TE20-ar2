using System;

namespace interaktiv_berättelse
{
    class Program
    {
        static void Main(string[] args)
        {

              Console.WriteLine("Du är i ett rum och ser 2 dörrar, väljer du (Höger/Vänster)");
           string dörr = Console.ReadLine();
            
            if (dörr == "Höger")
            {
              Console.WriteLine("Du kommer in i ett annat rum och ser nått men vet inte vad det är för att det är mörkt.");
            }
            else
            {
              Console.WriteLine("Du kommer in i ett annat rum och ser nått men vet inte vad det är för att det är mörkt.");

            }


            Console.WriteLine("Det finns två kistor tar du kista ett eller kista två");
            string kista = Console.ReadLine();

            if (kista == "ett")
            {
                Console.WriteLine("Du valde kista ett, du fick ett blått piller vill du äta den? Ja/nej?");
                kista = Console.ReadLine();
                if (kista == "ja")
                {
                    Console.WriteLine("du dog! Game over!");
                }
                else
                {
                    Console.WriteLine("du valde att inte äta, du vann!");
                }
            }

            if (kista == "två")
            {
                Console.WriteLine("Du valde kista två, du fick ett rött piller vill du äta den? ja/nej? ");
                kista = Console.ReadLine();
                if (kista == "ja")
                {
                    Console.WriteLine("En man kommer in i rummet och säger att du vann!");
                }
                else
                {
                    Console.WriteLine("En man kommer in i rummet och säger att du vann! Men du kan inte längre andas och dör");
                }
            }

        }
    }
}
