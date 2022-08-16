using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class TernaryOperatorDemo
    {
        static void Main(string [] args)
        {
            Console.WriteLine("Enter a first number");
            int num1 = int.Parse(Console.ReadLine());

            if (num1 > 0)
            {
                Console.WriteLine("Number is Positive");
            }
            else if(num1 < 0)
            {
                Console.WriteLine("Number is negative");
            }
            else
            {
                Console.WriteLine("Number is zero");
            }
            string str = num1 > 0 ? "Positive" : num1 < 0 ? "Negative" : "Zero";
            Console.WriteLine(str);

        }
    }
}
