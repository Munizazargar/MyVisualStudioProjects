using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            array_list();
            Console.ReadLine();
        }
        static void list()
        {
            List<string> a = new List<string>() { "zaid", "ali", "hanan" };
            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i]);
            }
            //1
            Console.WriteLine("-----------------------------------------------------");
            a.Add("sayar");
            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i]);
            }
            //2
            Console.WriteLine("-----------------------------------------------------");
            a.Insert(0, "laveezah");
            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i]);
            }
            //3
            Console.WriteLine("-----------------------------------------------------");
            a.Remove("zaid");
            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i]);
            }
            //4
            Console.WriteLine("-----------------------------------------------------");
            a.RemoveAt(1);
            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i]);
            }
            //5
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine(a.Count());
            //6
            Console.WriteLine("-----------------------------------------------------");
            bool x = a.Contains("zaid");
            Console.WriteLine(x);
            //7
            Console.WriteLine("-----------------------------------------------------");
            int A = a.IndexOf("sayar");
            Console.WriteLine(A);
            //8
            Console.WriteLine("-----------------------------------------------------");
            a.Reverse();
            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i]);
            }
            //9
            Console.WriteLine("-----------------------------------------------------");
            a.Sort();
            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i]);
            }
            //10
            Console.WriteLine("-----------------------------------------------------");
            a.Clear();
            Console.WriteLine(a.Count);


        }
        static void dictionary()
        {
            Dictionary <int,string> users = new Dictionary<int, string>()
            {
                {11,"zara"},
                {18,"irem" },
                {12,"sayar" }             
            };
            foreach (var user in users)
            {
                Console.WriteLine(user);
            }
            //1
            users.Add(22,"laveezah");
            foreach (var user in users)
            {
                Console.WriteLine(user);
            }
            //2
            users.Remove(18);
            foreach (var user in users)
            {
                Console.WriteLine(user);
            }
            //3
            int y = users.Count();
            Console.WriteLine(y);
            //4
            bool w = users.ContainsKey(11);
            Console.WriteLine(w);
            //5
            bool q = users.ContainsValue("sayar");
            Console.WriteLine(q);
            //6
            users.Clear();
            Console.WriteLine(users.Count());
            //7(update)
        }
        static void array()
        {
           /* int[] a = { 9, 2, 3, 6, 5, 11, 0, 8, 19, };
            foreach(int X in a)
            {
                Console.WriteLine(X);
            }
            //1
            Array.Reverse(a);
            foreach (int X in a)
            {
                Console.WriteLine(X);
            }
            //2
            Array.Sort(a);
            foreach (int X in a)
            {
                Console.WriteLine(X);
            }
            //3
            Array.Resize(ref a, 12);
            foreach (int X in a)
            {
                Console.WriteLine(X);
            }*/
            //OR

            Console.WriteLine("-----------------------------------------------------");

            int[] b = { 3, 2, 1};
            for (int i = 0 ; i < b.Length;i++)
            {
                Console.WriteLine(b[i]);
            }
            //1
            int x = b[0];
            int y = b[1];
            int z = b[2];
            if (x < y)
            {
                if (x < z)
                {
                    x = b[0];
                    if(y < z)
                    {
                        Console.WriteLine(x = b[0]);
                        Console.WriteLine(y = b[1]);
                        Console.WriteLine(z = b[2]);
                    }
                    else
                    {
                        Console.WriteLine(z = b[1]);
                        Console.WriteLine(y = b[2]);
                    }
                }
                else
                {
                    Console.WriteLine(z = b[0]);
                    Console.WriteLine(x = b[1]);
                    Console.WriteLine(y = b[2]);

                }
            }
            else 
            {
                if(z > y)
                {
                    y = b[0];
                    if (x > z)
                    {
                        Console.WriteLine(y = b[0]);
                        Console.WriteLine(z = b[1]);
                        Console.WriteLine(x = b[2]);
                    }
                    else
                    {
                        Console.WriteLine(x = b[1]);
                        Console.WriteLine(z = b[2]);
                    }
                }
                else
                {
                    Console.WriteLine(z = b[0]);
                    Console.WriteLine(y = b[1]);
                    Console.WriteLine(x = b[2]);
                }
            }
        }
        static void array_list()
        {
            ArrayList a = new ArrayList() { "zaid",111,true,9.87};
            foreach (var i in a)
            {
                Console.WriteLine(i);
            }
            //1
            int[] b = {1,2,3,4,5,6};
            a.AddRange(b);
            foreach(var i in a)
            {
                Console.WriteLine(i);
            }
            //2
            Console.WriteLine(a.Capacity);
            foreach (var i in a)
            {
                Console.WriteLine(i);
            }
            //3
            Console.WriteLine(a.Count);
            foreach (var i in a)
            {
                Console.WriteLine(i);
            }
            //4
            a.Add("lavee");
            foreach (var i in a)
            {
                Console.WriteLine(i);
            }
            //5
            a.RemoveAt(2);
            foreach (var i in a)
            {
                Console.WriteLine(i);
            }
            //6
            a.Clear();
            foreach (var i in a)
            {
                Console.WriteLine(i);
            }
            //queue nd stack 
            //fifo nd lifo
        }

    }
}
 