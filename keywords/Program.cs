using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static keywords.program;

namespace keywords
{
    internal class Program:program3<string>
    {
        static void Main(string[] args)
        {
            /* int[] a = { 11, 45, 23, 88 };
             string[] b = { "apple", "cat", "rose" };
             char[] c = { 'a', 'v', 'e' };
             double[] d = { 11.2, 12.5, 16.9 };
             program p = new program();
             p.prog(a);
             p.prog(b);
             p.prog(c);
             p.prog(d);



             try
             {
                 Console.WriteLine("ENTER YOUR AGE");
                 int age = int.Parse(Console.ReadLine());
                 if (age < 18)
                 {
                     throw new Exception("AGE CRITERIA VIOLATION");
                 }
             }
             catch (Exception)
             {
                 Console.WriteLine("PERSON MUST BE 18 OR OLDER");
             }
             finally
             {
                 Console.WriteLine("KEEP UR HELMET READY");
             }
            */
            //generic_methods
            //generix(data type safety)
            //<T> general data type

            program2<string> p2 = new program2<string>();
            Console.WriteLine(p2.Name = "laweezah");
            program2<int> p3 = new program2<int>();
            Console.WriteLine(p3.R_no = 1234);
            program2<double> p4 = new program2<double>();
            Console.WriteLine(p4.Gpa = 6.7);
            program2 <string> p5 = new program2<string>();
            p5.set_Grade("A");
            Console.WriteLine(p5.get_Grade());


            
            Console.ReadLine(); 
        }

        public string name()
        {
            throw new NotImplementedException();
        }
    }
    public class program
    {

        public void prog<T>(T[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

        }

        public class program2<T>
        {
            private T name;
            private T roll_number;
            private T gpa;
            private T grade;
            public T Name
            {
                set { name = value; }
                get { return name; }
            }
            public T R_no
            {
                set { roll_number = value; }
                get { return roll_number; }
            }
            public T Gpa
            {
                set{ gpa = value; }
                get { return gpa; }
            }
            public void set_Grade(T grade)
            {
                this.grade = grade;
            }
            public T get_Grade()
            {
                return grade;
            }
        }
    }
}
