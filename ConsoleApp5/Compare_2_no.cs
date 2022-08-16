using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Compare_2_no
    {
        static void Main(string[] args)
        {
            int n;
            int m;

            Console.WriteLine("Enter a number:");

            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            if (n == m)
            {
                Console.WriteLine( " All numbers are same.");
            }
            else if (n < m)
            {
                Console.WriteLine( " First number is a less than second number.");
            }
            else if (n > m)
            {
                Console.WriteLine(" First number is a greater than second number.");
            }
        }
    }
}
