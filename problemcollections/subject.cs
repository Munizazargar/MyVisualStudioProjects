using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problemcollections
{
    public class subject
    {
        public void inputs()
        {
            List<string> courses = new List<string>()
            {
            "mathematics","computer sciences","fine arts","medical sciences"
            };
            Console.WriteLine("press 1 to add a student's course");
            Console.WriteLine("press 2 to remove a student's course");
            Console.WriteLine("press 3 to update a student's course");
            Console.WriteLine("press 4 to display all courses");
            Console.WriteLine("press 5 to search a course");
            int a = int.Parse(Console.ReadLine());
            if (a == 1)
            {
                Console.WriteLine("enter student course");
                string c = Console.ReadLine();
                courses.Add(c);
                foreach (var x in courses)
                {
                    Console.WriteLine(x);
                }
            }
            if (a == 2)
            {
                Console.WriteLine("enter course to be removed ");
                string e = Console.ReadLine();
                courses.Remove(e);
                foreach (var x in courses)
                {
                    Console.WriteLine(x);
                }

            }
            if (a == 3)
            {
                Console.WriteLine("enter index of course to be updated");
                int h = int.Parse(Console.ReadLine());
                Console.WriteLine("enter updated course");
                string g = Console.ReadLine();
                courses[h] = g;
                foreach (var x in courses)
                {
                    Console.WriteLine(x);
                }

            }
            if (a == 4)
            {
                foreach (var x in courses)
                {
                    Console.WriteLine(x);
                }
            }
            if (a == 5)
            {
                Console.WriteLine("enter course to be searched");
                string t = Console.ReadLine();
                bool w = courses.Contains(t);
                Console.WriteLine(w);
            }
        }
    }
}
