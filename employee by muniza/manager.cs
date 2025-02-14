using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_by_muniza
{
    internal class manager
    {

        private string employee_name;
        private string employee_id;


        public string Employee_Name
        {
            set { employee_name = value; }
            get { return employee_name; }
        }

        public string Employee_Id
        {
            set { employee_id = value; }
            get { return employee_id; }

        }

    }
}
