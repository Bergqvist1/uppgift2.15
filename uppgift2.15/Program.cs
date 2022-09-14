using System;
namespace Uppgift_2_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en mening med 3 ord och punkt i slutet");

            var inputParts = Console.ReadLine().Split(' '); 
            string a = inputParts[0];
            string b = inputParts[1];
            string c = inputParts[2];

            Console.WriteLine(c + " " + b + " " + a + ".");


        }
    }
}

