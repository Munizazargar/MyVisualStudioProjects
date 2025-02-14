using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creditcardproperties
{
    public class account
    {
        private string acc_name;
        private int acc_no;
        private int amt;
        public string accname
        {
            set { acc_name = value; }
            get{ return acc_name; }
        }
        public int accno
        {
            set { acc_no = value; }
            get { return acc_no; }
        }
        public int amnt
        {
            set { amt = value; }
            get { return amt; }
        }







        

    }
}
