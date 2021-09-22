using System;

namespace interaktiv_berättelse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Det finns två kistor tar du kista ett eller kista två");
            string kista = Console.ReadLine();


            if (kista == "ett")
            {
                Console.WriteLine("Du valde kista ett, du fick ett blått piller");
            }

            if (kista == "två")
            {
                Console.WriteLine("Du valde kista två du fick ett rött piller");
            }

            Console.WriteLine("Du ser en knapp på väggen, trycker du på den eller inte");

            if (knapp == "tryck")
            {
                System.Console.WriteLine("Nu hör du en röst viska, ät pillret eller gå upp för trappan");
            }

        }
    }
}
