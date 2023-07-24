using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class UniqueString
    {
        static int Main1(string[] args)
        {
            int[] arr = new int[4];
            Boolean visted = false;
            int ele=0;
            int[] visitele = { };
            for (int i=0;i<arr.Length;i++) 
            {
                arr[i] = int.Parse(args[i]);

            }
            Console.WriteLine("These are the Elements");
            for (int i = 0; i < arr.Length; i++)
            {
              
                 Console.Write(" "+arr[i]);

            }
            Console.WriteLine("These Are Repeated elements");
            for (int i = 0; i < arr.Length; i++)
            {
               



            }

            



            return 0;
        }
    }
}
