using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANKSTRUCTURE
{
     abstract public class BANK
     {
        private string acc_no;
        private string acc_name;
        private string acc_balance;
        public string Acc_no
        {
            set { acc_no = value; }
            get { return acc_no; }
        }
        public string Acc_name
        {
            set { acc_name = value; }
            get { return acc_name; }
        }
        public string Acc_balance
        {
                set { acc_balance = value; }
                get { return acc_balance; }
        }
        public abstract void proces_payment();
        public abstract void get_receipt();
    }
}
