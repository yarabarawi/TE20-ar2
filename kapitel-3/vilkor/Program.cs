using System;

namespace vilkor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hur gammal är du? (heltal)");
            int ålder = int.Parse(Console.ReadLine());

            // "om ålder större än 18 du får ta körkort"
            if (ålder >= 18)
            {
                Console.WriteLine( "Du får ta körkort"  );
            }
            
            // om ålder är 15 eller högre du får ta moped körkort

            if (ålder >= 15)
            {
                Console.WriteLine("Du får ta moped körkort");
            }
      
            // Fråga användaren "Vad heter Abbas senaste Albumet?"
            Console.WriteLine("Vad heter Abbas senaste Albumet?");
            string låt = Console.ReadLine();



            if (låt == "Voyage" || låt == "voyage")
            {
                Console.WriteLine("Bra svarat");
            }
            
            else
            {
                Console.WriteLine("Fel! Albumet heter Voyage");
            }
            
            // sista TP-fråga
            Console.Write("Vem missade straffen för Frankrike");

            // läs in och tvinga till små bokstäver:
            // Mbappe -> mbappe
            // mBappe -> mbappe
            string spelare = Console.ReadLine();
            
            if (spelare == "mbappe")
            {
                Console.WriteLine("Bra, du är en expert!");
            }

            else
            {
                Console.WriteLine("Fel! Det var Mbappe");
            }

        }
    }
}
