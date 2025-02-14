using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeprops
{
    internal class manager
    {
        private string emp_name;
        private int emp_id;
        public string empname
        {
            set { emp_name = value; }
            get { return emp_name; }
        }
        public int empid
        {
            set { emp_id = value; }
            get { return emp_id; }
        }
        
    }
}
