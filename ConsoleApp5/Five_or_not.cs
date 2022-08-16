using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Five_or_not
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Enter a number:");

            n = int.Parse(Console.ReadLine());
            if (n == 5)
            {
                Console.WriteLine(n + " it is a same number or 5.");
            }
            else if (n < 5)
            {
                Console.WriteLine(n + " number is a less than five.");
            }
            else if (n > 5)
            {
                Console.WriteLine(n + " is a gretter than five.");
            }
        }
    }
}
