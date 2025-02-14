using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creditcardproperties
{
     public class creditcard
    {
        private int cc_no;
        public int ccno
        {
            set { cc_no = value; }
            get { return cc_no; }
        }
        public void info()
        {
            account a = new account();

            a.accname = "laweezah";
            a.accno = 1234;
            a.amnt = 9876;
            
            creditcard c1 = new creditcard();
            c1.cc_no = 1111;

            account b = new account();
            b.accname = "moin";
            b.accno = 4321;
            b.amnt = 8765;

            creditcard c2 = new creditcard();
            c2.cc_no = 4444;

            account d = new account();
            d.accname = "zaid";
            d.accno = 4301;
            d.amnt = 8005;
            
            creditcard c3 = new creditcard();
            c3.cc_no = 2002;


            Console.WriteLine("ACCOUNT NAME = " + a.accname);
            Console.WriteLine("ACCOUNT NO = " + a.accno);
            Console.WriteLine("AMOUNT = " + a.amnt);
            Console.WriteLine("CREDIT CARD NO = " +c1.cc_no);

            Console.WriteLine("ACCOUNT NAME = " + b.accname);
            Console.WriteLine("ACCOUNT NO = " + b.accno);
            Console.WriteLine("AMOUNT = " + b.amnt);
            Console.WriteLine("CREDIT CARD NO = " + c2.cc_no);

            Console.WriteLine("ACCOUNT NAME = " + d.accname);
            Console.WriteLine("ACCOUNT NO = " + d.accno);
            Console.WriteLine("AMOUNT = " + d.amnt);
            Console.WriteLine("CREDIT CARD NO = " + c3.cc_no);

        }
    }
}
