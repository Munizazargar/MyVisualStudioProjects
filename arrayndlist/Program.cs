using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayndlist
{
    internal class Program
    {  
        static void Main(string[] args)
        {
            int[] a = { 5, 2, 1, 4, 3, };
            Array.Sort(a);
            
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
            Array.Reverse(a);
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-----------------------------------------------------------------");
            //dictionary

            Dictionary<int,string> dict = new Dictionary<int, string>()
            {
                {01,"ali" },
                {02,"zaid" },
                {03,"hanan" }
            };
            foreach(var x in dict)
            {
                Console.WriteLine(x);
                Console.WriteLine(x.Key + " " +x.Value);
            }
            Console.WriteLine("-----------------------------------------------------------------");
            //adding
            dict.Add(11, "laveezah");
            foreach (var x in dict)
            {
                Console.WriteLine(x);
                Console.WriteLine(x.Key + " " + x.Value);
            }
            Console.WriteLine("-----------------------------------------------------------------");
            //removing
            dict.Remove(11);
            foreach (var x in dict)
            {
                Console.WriteLine(x);
                Console.WriteLine(x.Key + " " + x.Value);
            }
            Console.WriteLine("-----------------------------------------------------------------");
            //exists
            bool i = dict.ContainsKey(11);
            foreach (var x in dict)
            {
                Console.WriteLine(x);
                Console.WriteLine(x.Key + " " + x.Value);
            }
            Console.WriteLine("-----------------------------------------------------------------");
            //update
            dict[11] = "alizah";
            foreach (var x in dict)
            {
                Console.WriteLine(x);
                Console.WriteLine(x.Key + " " + x.Value);
            }
            Console.WriteLine("-----------------------------------------------------------------");
            //clear
            dict.Clear();
            foreach (var x in dict)
            {
                Console.WriteLine(x);
                Console.WriteLine(x.Key + " " + x.Value);
            }




            Console.ReadLine();
        }
    }
}
