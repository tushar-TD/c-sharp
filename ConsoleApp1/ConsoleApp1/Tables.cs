using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Tables
    {
        static int Main3(string[] args)
        {
            Console.WriteLine("Tables are given below:");
            for (int i = 2; i < 12; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(i +"X"+ j+ "=" +i * j);
                }
                Console.WriteLine("\n");
            }
            return 0;
        }
    }
}
