using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop2
{
    internal class grade
    {
        float marks;
        string name1;

        public grade(float marks, string name1)
        {
            this.marks = marks;
            this.name1 = name1;
        }

        public void Getgrade(float marks)
        {
            if (marks >= 90)
                Console.WriteLine("Excellent!");
            else if (marks >= 80 && marks <= 90)
            {
                Console.WriteLine("Very Good!");
            }
            else if (marks >= 70 && marks <= 80)
            {
                Console.WriteLine("Good!");
            }
            else
                Console.WriteLine("take More Efforts");



        }
    }
}
