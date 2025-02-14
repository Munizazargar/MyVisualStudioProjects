using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPORT_CARD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PRESS 1 TO CREATE STUDENT PROFILE");
            Console.WriteLine("PRESS 2 TO DISPLAY STUDENT'S PROFILE");
            int A = int.Parse(Console.ReadLine());
            if (A == 1)
            {
                student_data();
            }
            if (A == 2)
            {
                Console.WriteLine("ENTER THE NAME OF STUDENT WHOSE PROFILE IS TO BE DISPLAYED");
                string B = Console.ReadLine();
                string C = B + ".txt";
                using (StreamReader sr = new StreamReader(C))
                {
                    string read = File.ReadAllText(C);
                    Console.WriteLine(read);
                }
            }
            Console.ReadLine();
        }
        static void student_data()
        {
            Console.WriteLine("ENTER THE NAME OF STUDENT");
            string a = Console.ReadLine();
            Console.WriteLine("ENTER THE ROLL NO OF STUDENT");
            string b = Console.ReadLine();
            Console.WriteLine("ENTER THE CLASS OF STUDENT");
            string c = Console.ReadLine();
            Console.WriteLine("ENTER THE FINAL PERCENTAGE OF STUDENT");
            string d = Console.ReadLine();
            Console.WriteLine("ENTER THE STREAM OF STUDENT");
            string e = Console.ReadLine();
            string f = a+ ".txt";
            using (StreamWriter s = new StreamWriter(f))
            {
                s.WriteLine(a);
                s.WriteLine(b);
                s.WriteLine(c);
                s.WriteLine(d);
                s.WriteLine(e);
            }

        }
    }
}
