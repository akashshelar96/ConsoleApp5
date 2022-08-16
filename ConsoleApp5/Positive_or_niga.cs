using System;

namespace ConsoleApp5
{
    class Positive_or_niga
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Enter a number:");

            n = int.Parse(Console.ReadLine());
            if(n==0)
            {
                Console.WriteLine(n + " is zero.");
            }
            else if(n>0)
            {
                Console.WriteLine(n + " is a positive number.");
            }
            else
            {
                Console.WriteLine(n + " is a negative number.");
            }
        }
    }
}
