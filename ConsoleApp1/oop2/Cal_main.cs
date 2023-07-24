using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace oop2
{
    internal class Cal_main
    {
        static int Main2(string[] args)
        {
            Console.WriteLine("Enter Number1:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number2:");
            int b = int.Parse(Console.ReadLine());
            Program p = new Program();
            Console.WriteLine("------------------");
            Console.WriteLine(p.Add(a,b));
            Console.WriteLine(p.Multiply(a,b));
            Console.WriteLine(p.Divide(a,b));
            Console.WriteLine(p.Sub(a,b));
            return 0;
        }
           
        }
}
