using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayprime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 7, 8, 9 };
            int d;
       
            for (int i = 0; i < a.Length; i++)
            {
                for (d = 2; d < a[i]; d++)
                {
                    if (a[i] % d != 0)
                    {

                        Console.WriteLine(a[i]);
                    }
                }

            }
            Console.ReadLine();
        }
        static void even()
        {
            int[] a = { 7, 8, 9 };
            foreach (int i in a)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " is even ");
                }
                else
                {
                    Console.WriteLine(i+ " is odd ");
                }

            }
        }
    }
}
