using System;

namespace Uppgift_3._14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du gått ut gymnasiet (j/n)");
            string gymnasiet = Console.ReadLine();

            Console.WriteLine("hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());

            if (gymnasiet == "j" && ålder < 22)
            {
                Console.WriteLine("Vi vill gärna anställa dig");
            }
            else
            {
                Console.WriteLine("Vi letar efter någon annan just nu");
            }


        }
    }
}
