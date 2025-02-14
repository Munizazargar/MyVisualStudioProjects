using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BILLING
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("PRESS 1 TO ENTER CUSTOMER DETAILS");
            Console.WriteLine("PRESS 2 TO DISPLAY CUSTOMER DETAILS");
            int w = int.Parse(Console.ReadLine());



            if (w == 1)
            {
                customer_details();
            }
            if (w == 2)

            {
                Console.WriteLine("ENTER THE CUSTOMERS's NAME TO GET DETAILS");
                string A = Console.ReadLine();
                string B = A + ".txt";
               

                using (StreamReader s = new StreamReader(B))
                {
                    string reads = File.ReadAllText(B);
                    Console.WriteLine(reads);
                }
                Console.ReadLine();
            }
        }
        static void customer_details()
        {
            Console.WriteLine("ENTER THE CUSTOMER NAME");
            string o = Console.ReadLine();
            Console.WriteLine("ENTER THE CUSTOMER ID");
            string a = Console.ReadLine();
            Console.WriteLine("ENTER THE PHONE NUMBER OF CUSTOMER");
            string b = Console.ReadLine();
            Console.WriteLine("ENTER THE EMAIL ID OF CUSTOMER");
            string c = Console.ReadLine();
            Console.WriteLine("ENTER THE DISCOUNT GIVEN TO THE CUSTOMER");
            string d = Console.ReadLine();
            Console.WriteLine("ENTER THE DATE");
            string e = Console.ReadLine();
            Console.WriteLine("ENTER THE AMOUNT OF SHOPPING");
            string f = Console.ReadLine();
            Console.WriteLine("ENTER THE TOTAL BILL AFTER DISCOUNT");
            string g = Console.ReadLine();
            string h = o+".txt";
            

            using (StreamWriter s = new StreamWriter(h))
            {
                s.WriteLine(a +"\n"+ b +"\n"+ c+"\n"+ d+"\n"+ e+"\n" + f);
            }
            

        }
        
    }
}
