﻿using System;

namespace Uppgift_4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skriv din summa. t.ex 537
            Console.WriteLine("Skriv din summa");
            string summaText = Console.ReadLine();

            // loop igenom summaText
            int summa = 0;
            for (int i = 0; i <summaText.Length; i++)
            {
                Console.WriteLine(summaText[i]);

                char siffra = summaText[i];
                Console.WriteLine(siffra);

                // omvandla char -> strin -> int
                // omvandla char med .ToString()
                int siffraTal = int.Parse (siffra.ToString()) ; 

                // Addera till summan
                summa += siffraTal; 
            }
            
            
        }
    }
}
