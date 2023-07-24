using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace oop2
{
    internal class Add_main
    {
        static void Main3(string[] args)
        {
            Console.WriteLine("Enter the marks:");
            float marks = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the name:");
            string name = Console.ReadLine();
            grade g=new grade(90f,"Tushar");
            g.Getgrade(marks);

        }
    }
}
