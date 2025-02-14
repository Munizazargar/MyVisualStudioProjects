using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeprops
{
    internal class employee
    {
        private int experience;
        private int salary;
        public int exp
        {
            set { experience = value; }
            get { return experience; }
        }
        public int salarie
        {
            set { salary = value; }
            get { return salary; }
        }
        public void info()
        {
            manager m = new manager();
            m.empname = "laweezah";
            m.empid = 1;
            employee E = new employee();
            E.exp = 4;
            E.salarie = 50000;
            int SALARY = E.exp * E.salarie;

            Console.WriteLine("EMPLOYEE NAME = " + m.empname);
            Console.WriteLine("EMPLOYEE ID = " + m.empid);
            Console.WriteLine("EXPERIENCE = " + E.exp);
            Console.WriteLine("SALARY OF EMPLOYEE = " + SALARY);

        }
    }
}
