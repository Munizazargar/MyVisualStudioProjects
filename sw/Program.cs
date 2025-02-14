using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //WRITING THE TEXT IN .TXT
            string path = "abc.txt";
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("path via sw");
            }
            Console.WriteLine("Task completed");
           

            string path2 = "def.txt";
            File.WriteAllText(path2, "path2 via file.writealltext");
            Console.WriteLine("Task completed");

            //APPENDING THE TEXT IN .TXT
          
            
            
            Console.WriteLine("Task completed");

            File.AppendAllText(path2, "appended part");

            //READING THE TEXT

            using (StreamReader sr = new StreamReader(path2))
            {
                string read = File.ReadAllText(path2);
            }












            Console.ReadLine();
        }
    }
}
