using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CREDITCARD
{
    internal class UPI
    {
        private int upipin;
        public void setupipin(int upipin)
        {
            this.upipin = upipin;
        }
        public int getupipin()
        {
            return this.upipin;  
        }
        public void infoacccrd()
        {
            ACCOUNT ACCOUNT1 = new ACCOUNT();
            ACCOUNT1.setaccname("laveeza");
            ACCOUNT1.setaccountno(1001);
            ACCOUNT1.setamount(122);

            ACCOUNT ACCOUNT2 = new ACCOUNT();
            ACCOUNT2.setaccname("moin");
            ACCOUNT2.setaccountno(2133);
            ACCOUNT2.setamount(112);

            Console.WriteLine("account name = " + ACCOUNT1.getaccname());
            Console.WriteLine("account no = " + ACCOUNT1.getaccountno());
            Console.WriteLine("amount = " + ACCOUNT1.getamount());

            Console.WriteLine("account name = " + ACCOUNT2.getaccname());
            Console.WriteLine("account no = " + ACCOUNT2.getaccountno());
            Console.WriteLine("amount = " + ACCOUNT2.getamount());
            
            upipin = 9534;
            Console.WriteLine("upi pin = "+ upipin);
        }
    }
}
