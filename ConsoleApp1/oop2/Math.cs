using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop2
{
    internal class Math
    {
        public void Add2int(int a,int b) 
        {
            Console.WriteLine($"{a} + {b} = " +(a+b));
        }
        public void Add3int(int a,int b,int c)
        {
            Console.WriteLine($"{a} + {b} + {c} = " + (a+b+c) );
        }

        public void Add2flt(float a,float b) 
        {
            Console.WriteLine($"{a} + {b} =" +(a+b));
        }
    }
}
