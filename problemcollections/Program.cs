using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problemcollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student student = new student();
            student.inputs();

            subject subject = new subject();
            subject.inputs();
            Console.ReadLine();
        }
    }
}
