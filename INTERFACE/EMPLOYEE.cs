using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERFACE
{
    public class EMPLOYEE : HR, MANAGER
    {
        public string Emp_name 
        { 
           set ; get;
        }
        public string Emp_id 
        {
            set; get;
        }
        public string Emp_designation 
        {
            set;get;
        }
        public string Emp_team 
        {
            set;get;
        }

        public void emp_info()
        {
            Console.WriteLine(Emp_name + " " + Emp_id + " " + Emp_designation + " " + Emp_team);
        }

       

        public void role()
        {
            Console.WriteLine(Emp_designation+ " "+ Emp_team);
        }

      
    }
}
