using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACCOUNTS
{
    public class ACCOUNT<T>
    {
        public int amt;
        private T acc_no;
        private T acc_type;
        public void set_acc_no(T acc_no)
        {
            this.acc_no = acc_no;
        }
        public T get_acc_no()
        {
            return acc_no;
        }
        public void set_acc_type(T acc_type)
        {
            this.acc_type = acc_type;
        }
        public T get_acc_type()
        {
            return acc_type;
        }
        public void deposit<T>()
        {
            Console.WriteLine("ENTER AMOUNT");
            T amt = T (typeof)(Console.ReadLine());   
            //typeof data type
        }
        private T acc_name;
        public T Acc_name
        {
            set { acc_name = value; }
            get { return acc_name; }
        }
        private T balance;
        public T Balance
        {
            set { balance = value; }
            get { return balance; }
        }
        public void confirmation()
        {
            Console.WriteLine("THE " + acc_type + " BANK ACCOUNT OF " + acc_name + " HAVING ACCOUNT NO = " + acc_no + " IS HAVING A TOTAL BALANCE OF = " + balance + " AFTER THE WITHDRAWAL OF RS = " + amt);
        }

    }
}
