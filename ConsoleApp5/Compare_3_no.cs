using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Compare_3_no
    {
        static void Main(string[] args)
        {
            
            {
                int a;
                int b;
                int c;

                Console.WriteLine("Enter a number:");

                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = int.Parse(Console.ReadLine());
                if (a == b && b == c && a==c)
                {
                    Console.WriteLine(" All numbers are same.");
                }
                else if (a < b && b < c && a < c)
                {
                    Console.WriteLine(" First number is a less than second number and socond number is a less than third number and third number is a greater than first number.");
                }
                else if (a > b && b > c && a > c)
                {
                    Console.WriteLine("  First number is a greater than second number and socond number is a greater than third number and third number is a less than first number.");
                }
                else if (a > b && b < c && a > c)
                {
                    Console.WriteLine("  First number is a Greater than second number and socond number is a less than third number and third number is a less than first number.");
                }
                else if (a > b && b > c && a < c)
                {
                    Console.WriteLine("  First number is a Greater than second number and socond number is a greater than third number and third number is a greater than first number.");
                }
                else if (a > b && b < c && a < c)
                {
                    Console.WriteLine(" First number is a greater than second number and socond number is a less than third number and third number is a greater than first number.");
                }

            }
            
        }


    }
}
