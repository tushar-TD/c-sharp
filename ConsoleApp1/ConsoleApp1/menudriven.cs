using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class menudriven
    {
        static int Main2(string[] args)
        {
            Console.WriteLine("Marks in Maths");
            int maths = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Marks in Physics");
            int physics = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Marks in Chemistry");
            int chemistry = Convert.ToInt32(Console.ReadLine());

            int sum = physics + chemistry + maths;
            if (sum >= 180 && physics >= 55 && chemistry >= 50 && maths >= 65)
            {
                Console.WriteLine("You are Eligible!");
            }
            else
                Console.WriteLine("You are not eligible");

            return 0;
        }
            
        }
    }
