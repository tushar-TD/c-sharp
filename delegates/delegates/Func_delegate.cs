using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    internal class Func_delegate
    {
        static void Main(string[] args)
        {
            Math_operations mo=new Math_operations();
            Func<int, int, int> f = mo.Add;
            int res = f(9,1);
            Console.WriteLine(res);

            Func<int, int, int> f1 = mo.Sub;
            int res2 = f1(9,1);
            Console.WriteLine(res2);

        }
    }

    class Math_operations 
    {
        public int Add(int a,int b)
        {
            Console.WriteLine("In Add:");
            return a + b;
        }

        public int Sub(int a,int b) 
        {
            Console.WriteLine("Substraction:");
            return a - b;
        }
    }
}
