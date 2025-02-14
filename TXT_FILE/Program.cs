using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TXT_FILE
{
    internal class Program
    {
        static string path = "CREATE_USER.txt";
        static void Main(string[] args)
        {
            create_user();
            
          
            Console.ReadLine();
        }
        static void create_user()
        {
            Console.WriteLine("PRESS 1 TO CREATE USER");
            Console.WriteLine("PRESS 2 TO GET DETAILS OF USERS");
            Console.WriteLine("PRESS 3 TO ADD USER");
            int w = int.Parse(Console.ReadLine());
            if (w == 1)
            {
                user();
            }
            if (w == 2)
            {
                read();
            }
            if (w == 3)
            {
                append();
            }

        }
        static void user()
        {
            Console.WriteLine("ENTER YOUR FIRST NAME");
            string A = Console.ReadLine();
            Console.WriteLine("ENTER YOUR SECOND NAME");
            string B = Console.ReadLine();
            Console.WriteLine("ENTER YOUR PHONE NUMBER");
            string C = Console.ReadLine();
            Console.WriteLine("ENTER YOUR EMAIL ID");
            string D = Console.ReadLine();

            using (StreamWriter SW = new StreamWriter(path,true))
            {

                SW.WriteLine(A);
                SW.WriteLine(B);
                SW.WriteLine(C);
                SW.WriteLine(D);

            }
            
        }
        static void read()
        {
            using (StreamReader SW = new StreamReader(path))
            {
                string read = File.ReadAllText(path);
                Console.WriteLine(read);
            }
        }
        static void append()
        {

            Console.WriteLine("ENTER YOUR FIRST NAME");
            string A = Console.ReadLine();
            Console.WriteLine("ENTER YOUR SECOND NAME");
            string B = Console.ReadLine();
            Console.WriteLine("ENTER YOUR PHONE NUMBER");
            string C = Console.ReadLine();
            Console.WriteLine("ENTER YOUR EMAIL ID");
            string D = Console.ReadLine();


            File.AppendAllText(path, A+B+C+D);
        }
        
        
        
        
        
    }
}
