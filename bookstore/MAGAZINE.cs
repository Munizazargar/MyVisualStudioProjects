using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstore
{
    public class MAGAZINE :LIBRARY
    {

        private int DATE_OF_ISSUE;
        private string COMPANY;
       
        public int date_of_issue
        {
            set { DATE_OF_ISSUE = value; }
            get { return date_of_issue; }
        }
        public string company
        {
            set { COMPANY = value; }
            get { return company; }
        }
        public void info(string name, string company, string id, int issue, int day, int price)
        {
            Console.WriteLine(name + " " + company + " " + id+ " " + issue + " " + day + " " + price);

        }
    }
}
