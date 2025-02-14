using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problemcollections
{
    public class student
    {
        public void inputs()
        {
            Dictionary<int, string> students = new Dictionary<int, string>()
            {
                {01,"laveezah" },
                {02,"sayar" },
                {03,"hanan" },
                {04,"zaid" },
                {05,"mehran" }
            };
            Console.WriteLine("press 1 to add a student");
            Console.WriteLine("press 2 to remove a student");
            Console.WriteLine("press 3 to update a student's name");
            Console.WriteLine("press 4 to display all students");
            Console.WriteLine("press 5 to search a student");
            int a = int.Parse(Console.ReadLine());
           
            if( a == 1)
            {
                Console.WriteLine("enter student roll no");
                int c = int.Parse(Console.ReadLine());
                Console.WriteLine("enter student name");
                string d = Console.ReadLine();
                students.Add(c,d);
                foreach (var x in students)
                {
                    Console.WriteLine(x);
                }
            }
            if (a == 2)
            {
                Console.WriteLine("enter student roll no");
                int e = int.Parse(Console.ReadLine());
                students.Remove(e);
                foreach (var x in students)
                {
                    Console.WriteLine(x);
                }

            }
            if ( a == 3)
            {
                Console.WriteLine("enter roll no to be updated");
                int z = int.Parse(Console.ReadLine());
                Console.WriteLine("enter updated name");
                string g = Console.ReadLine();
                students[z]= g;
                foreach (var x in students)
                {
                    Console.WriteLine(x);
                }

            }
            if (a == 4)
            {
                foreach (var x in students)
                {
                    Console.WriteLine(x);
                }
            }
            if (a == 5)
            {
                Console.WriteLine("enter the roll no of student to be searched");
                int r = int.Parse(Console.ReadLine());
                bool Q = students.ContainsKey(r);
                Console.WriteLine(students[r]);
                

            }
        }
    }
}
