using System;

namespace Uppgift_2_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en mening med 3 ord och punkt i slutet");
            string mening = Console.ReadLine();

            string[] ord = mening.Split(' ', '.');

            Console.WriteLine("Backlänges blir din mening " + ord[2] + " " + ord[1] + " " + ord[0] + ".");


        }
    }
}

