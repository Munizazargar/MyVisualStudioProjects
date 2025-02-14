using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_handling
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            
            Console.ReadLine();
        }
        static void DivideByZeroException()
        {
            try
            {
                Console.WriteLine("ENTER FIRST NO");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("ENTER SECOND NO");
                int b = int.Parse(Console.ReadLine());
                int c = a / b;
                Console.WriteLine(c);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("DIVISION BY ZERO IS NOT ALLOWED");
            }
        }
        static void IndexOutOfRangeException()
        {
            try
            {
                int[] a = { 1, 2, 3, 4, 5 };
                for (int i = 0; i <= a.Length; i++)
                {
                    Console.WriteLine(a[i]);
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("LAST INDEX OF ARRAY IS ONE LESS THAN THE NO OF TOTAL ELEMENTS IN ARRAY");
            }
        }
        static void FormatException()
        {
            try
            {
                Console.WriteLine("ENTER THE IST NUMBER");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("ENTER THE 2ND NUMBER");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine( a*b);
            }
            catch (FormatException e)
            {
                Console.WriteLine("ENTER A VALID NUMBER");
            }
        }
        static void FileNotFoundException()
        {
            try
            {

                string file = "NCERT.txt";
                using (StreamReader sr = new StreamReader(file))
                {
                    string read = File.ReadAllText(file);
                    Console.WriteLine(read);
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("FILE DOESN'T EXIST");
            }
        }
        

    }
}
