using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main4(string[] args)
        {
            Console.WriteLine("Enter the Number:");
            int num = int.Parse(Console.ReadLine());
            int num1 = num;
            int reversed = 0;
            int rem;

            while (num1 > 0)
            {
                rem = num1 % 10;
                reversed = reversed * 10 + rem;
                num1 = num1 / 10;
            }

            if (num == reversed)
            {
                Console.WriteLine("It is a palindrome!");
            }
            else
            {
                Console.WriteLine("It is not a palindrome!");
            }
        }
    }
}
