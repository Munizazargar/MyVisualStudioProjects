using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //generix mutable non generix immutable
            Hashtable ht = new Hashtable();//dictionary
            ht.Add('a', 2);
            ht.Add(2, "zaid");
            ht.Add(3, 4);
            foreach (DictionaryEntry s in ht)
            {
              //  Console.WriteLine(s.Key + " " + s.Value);
            }
            bool i = ht.Contains("a");
           // Console.WriteLine(i);
            int c = ht.Count;
           // Console.WriteLine(c);
            Console.WriteLine("--------------------------------------------");
            Hashtable ht2 = (Hashtable)ht.Clone();
            foreach (DictionaryEntry s in ht2)
            {
                Console.WriteLine(s.Key + " " + s.Value);
            }
            //ht.Clear();

            // new_hash = ht.Clone();

            //sorted list
            SortedList sl = new SortedList();//list
            sl.Add("c", 2);
            sl.Add("b", "zaid");
            sl.Add("a", 4);
            foreach (DictionaryEntry s in sl)
            {
              //  Console.WriteLine(s.Key+" " + s.Value );
            }
            //sl.Add();
            sl.RemoveAt(2);
            foreach (DictionaryEntry s in sl)
            {
               // Console.WriteLine(s.Key + " " + s.Value);
            }
           // Console.WriteLine("_____________________");
           // Console.WriteLine(sl.Capacity = c);
            bool z = ht.ContainsKey(c);
           // Console.WriteLine(z);
            SortedList sl2 = (SortedList)sl.Clone();
            foreach (DictionaryEntry s in sl)
            {
              //  Console.WriteLine(s.Key + " " + s.Value);
            }

            //sl.Clear();


            //queue and stack and dictionary (non genericx)

            Console.ReadLine();
        }
    }
}
