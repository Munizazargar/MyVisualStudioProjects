using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERFACE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EMPLOYEE e = new EMPLOYEE();
            e.Emp_name = "Emp_name = laveeza";
            e.Emp_id = "Emp_id = 1122";
            e.Emp_designation = "Emp_designation = c# developer";
            e.Emp_team = "Emp_team = 07";
            

            e.emp_info();
            e.role();


            Console.ReadLine();
        }
    }
}
