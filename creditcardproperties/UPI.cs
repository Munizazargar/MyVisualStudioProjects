using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creditcardproperties
{
    public class UPI
    {
        private int upi_pin;
        public int upipin
        {
            set { upi_pin = value; }
            get { return upi_pin; }
        }
        public void info()
        {
            account a = new account();

            a.accname = "laweezah";
            a.accno = 1234;
            a.amnt = 9876;
            
            UPI u1 = new UPI();  
            u1.upi_pin = 1122;

            account b = new account();

            b.accname = "moin";
            b.accno = 8787;
            b.amnt = 3223;

            UPI u2 = new UPI();
            u2.upi_pin = 4334;

            account d = new account();
            d.accname = "zaid";
            d.accno = 4301;
            d.amnt = 8005;

            UPI u3 = new UPI();
            u3.upi_pin = 4884;

            Console.WriteLine("ACCOUNT NAME = " + a.accname);
            Console.WriteLine("ACCOUNT NO = " + a.accno);
            Console.WriteLine("AMOUNT = " + a.amnt);
            Console.WriteLine("UPI PIN = " + u1.upi_pin);

            Console.WriteLine("ACCOUNT NAME = " + b.accname);
            Console.WriteLine("ACCOUNT NO = " + b.accno);
            Console.WriteLine("AMOUNT = " + b.amnt);
            Console.WriteLine("UPI PIN = " + u2.upi_pin);

            Console.WriteLine("ACCOUNT NAME = " + d.accname);
            Console.WriteLine("ACCOUNT NO = " + d.accno);
            Console.WriteLine("AMOUNT = " + d.amnt);
            Console.WriteLine("UPI PIN = " + u3.upi_pin);
        }
    }
}
