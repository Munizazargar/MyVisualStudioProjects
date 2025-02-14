using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_by_muniza
{
    internal class intern
    {
        private int hours;
        private int work_rate;
        

        public int Hours
        {
            set { hours = value; }
            get { return hours; }
        }
        public int Work_rate 
        {
            set { hours = value; }
            get { return hours; }
        }
        public void info_2()
        {
            manager m=new manager();
            Console.WriteLine( m.Employee_Name = "bashie"+ "is the intern name");
            Console.WriteLine(m.Employee_Id = "1345" + "is the intern id");
            intern i = new intern();
            Console.WriteLine(i.hours = 6 );
            Console.WriteLine(i.work_rate = 20);
        }
    }
    



    
}
