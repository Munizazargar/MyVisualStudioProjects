using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inherit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Console.WriteLine(employee.Exp = 3);
            Console.WriteLine(employee.Amount = 10000);
            Console.WriteLine(employee.EmployeeName = "muniza");
            Console.WriteLine( employee.Employee_ID = 8339);
            employee.salary();

            Console.ReadLine();
        }

    }
    public class manager
    {
        private int employee_id;
            public int Employee_ID
            {
            set { employee_id = value; }
            get { return employee_id; }
            }
        private string employee_name;
            public string EmployeeName
            {
            set { employee_name = value; }
            get { return employee_name; }
            }


    }
}
