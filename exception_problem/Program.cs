using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                

                Console.WriteLine("ENTER THE FIRST NO");
                int a = int.Parse(Console.ReadLine());
               
                Console.WriteLine("ENTER THE SECOND NO");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("ENTER THE NAME OF TEXT FILE");
                string c = Console.ReadLine();

                int m = a / b;


                Console.ReadLine();
                
                
                
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("DIVISION WITH ZERO IS NOT ALLOWED");
            }
            catch (FormatException e)
            {
                Console.WriteLine("INVALID INPUT ");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
    }
}
