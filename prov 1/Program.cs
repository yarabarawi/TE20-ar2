using System;

namespace prov_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Uträkning av bruttolön!");

            Console.WriteLine("Vad heter du?");
            Console.ReadLine();
            
            Console.WriteLine("Ange din bruttolön i kr");
            Console.ReadLine();
            int bruttolön = int.Parse(Console.ReadLine());

            if (bruttolön >= 10000)
            {
                Console.WriteLine("Bruttolön måste vara över 10000kr");
            }
            else
            {
                Console.WriteLine("vad är din skatte sats i %");
            }

            




        }
    }
}
