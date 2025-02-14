using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CREDITCARD
{
    public  class CREDITCARD
    {
       
        private int creditcardno;
        public void setccno(int creditcardno)
        {
            this.creditcardno = creditcardno;
        }
        public int getccno()
        {
            return this.creditcardno;
        }
        public void infoacc()
        {
            ACCOUNT ACCOUNT1 = new ACCOUNT();
            ACCOUNT1.setaccname("laveeza");
            ACCOUNT1.setaccountno(1001);
            ACCOUNT1.setamount(122);
            creditcardno = 1224556677;

            ACCOUNT ACCOUNT2 = new ACCOUNT();
            ACCOUNT2.setaccname("moin");
            ACCOUNT2.setaccountno(2133);
            ACCOUNT2.setamount(112);

            Console.WriteLine("account name = " +ACCOUNT1.getaccname());
            Console.WriteLine("account no = " + ACCOUNT1.getaccountno());
            Console.WriteLine("amount = " + ACCOUNT1.getamount());
            Console.WriteLine("credit card no = " + creditcardno);

            Console.WriteLine("account name = " + ACCOUNT2.getaccname());
            Console.WriteLine("account no = " + ACCOUNT2.getaccountno());
            Console.WriteLine("amount = " + ACCOUNT2.getamount());
            Console.WriteLine("credit card no = " + creditcardno);

        }

    }
}
