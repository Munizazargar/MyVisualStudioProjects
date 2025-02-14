using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CREDITCARD
{
    public class ACCOUNT
    {
        private string accountname;
        private int accountno;
        private int amount;
        public void setaccname(string accountname)
        {
            this.accountname = accountname;
        }
        public string getaccname()
        {
            return this.accountname;
        }
        public void setaccountno(int accountno)
        {
            this.accountno = accountno;
        }
        public int getaccountno()
        {
            return this.accountno;
        }
        public void setamount(int amount)
        {
            this.amount = amount;
        }
        public int getamount()
        {
            return this.amount;
        }
    }
}
