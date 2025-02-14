using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_by_muniza
{
    internal class Program
    {
        static void Main(string[] args)
        {

            employee e = new employee();
            e.info();
            intern i = new intern();
            i.info_2();
            Console.ReadLine();

        }
    }
    class employee
    {

        private int experience;
        private int salary;

        public int Experience
        {
            set { experience = value; }
            get { return experience; }
        }s
        public int Salary
        {
            set { salary = value; }
            get { return salary; }
        }
        public void info()
        {
            manager m = new manager();
            Console.WriteLine(m.Employee_Name = "muniza"+ "is the employee name");
            Console.WriteLine(m.Employee_Id = "123"+"is the employee id");
              employee e = new employee();
            Console.WriteLine(e.salary = 20000 );
            Console.WriteLine(e.experience = 2 );



        }



    }





}
