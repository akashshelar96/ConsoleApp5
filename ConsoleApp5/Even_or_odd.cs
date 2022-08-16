using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Even_or_odd
    {
        static void Main(string[] args)
        {
            int i;

            Console.WriteLine("Enter a number:");

            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)

            {
                Console.WriteLine(i + " it is Even number .");
                Console.Read();
            }
            else
            {
                Console.WriteLine(i + " it is a odd number.");
                Console.Read();
            }
        }
    }
}