using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Greatest_number
    {
        static void Main(string [] args)
        {
            Console.WriteLine("Enter a 1s number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a 2nd number:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a 3rd number:");
            int num3 = int.Parse(Console.ReadLine());

            if(num1 > num2 && num1 > num3)
            {
                Console.WriteLine("Number 1 is greater:");
            }
            else if(num2 > num1 && num2 > num3)
            {
                Console.WriteLine("Number 2 is greater:");
            }
            else
            {
                Console.WriteLine("Number 3 is greater:");
            }
                       
        }
    }
}
