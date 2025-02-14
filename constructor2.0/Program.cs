using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            laptops hp = new laptops("hp", "i5", "8th");
            Console.WriteLine(hp.names + "\n" + hp.processors + "\n" + hp.generations);
           
            laptops dell = new laptops("dell", "i7", "7th");
            Console.WriteLine(dell.names + "\n" + dell.processors +"\n" + dell.generations);
            
            laptops asus = new laptops("asus", "i8", "6th");
            Console.WriteLine(asus.names + "\n" + asus.processors + "\n" + asus.generations);
            
                
                
            Console.ReadLine();
        }
    }
    class laptops
    {
        public string names;
        public string processors;
        public string generations;

        public laptops(string name, string processor, string generation)
        {
            names = name;
            processors = processor;
            generations = generation;
        }

    }

    
}
