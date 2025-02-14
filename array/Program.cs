using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int [5] { 12, 160, 90, 55, 11 };
            int g;
            int num;
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(num = a[i]);
            }
            if (a[0] > a[1])
            {
                g = a[0];
                if (a[0] > a[2])
                {
                    g= a[0];
                    if (a[0] > a[3])
                    {
                        g = a[0];
                        if(a[0] > a[4])
                        {
                            g = a[0];
                        }
                        else
                        {
                            g = a[4];
                        }
                    }
                    else
                    {
                        g = a[3];
                    }
                }
                else
                {
                    g = a[2];
                }
            }
            else
            {
                g = a[1];
                if (a[1] > a[2]) 
                { 
                    g = a[1]; 
                    if(a[1] > a[3])
                    {
                        g = a[1];
                        if( a[1] > a[4])
                        {
                            g = a[1];
                        }
                    }
                }
                else
                {
                    g = a[2];
                }
            }












            Console.WriteLine(g + " is greatest ");
            Console.ReadLine();
        }
        
    } 
}
