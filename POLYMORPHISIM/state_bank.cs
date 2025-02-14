using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLYMORPHISIM
{
    public class state_bank :central_bank
    {
        public override void no_of_employees()
        {
            Console.WriteLine("state bank has 100 employees");
        }
        public override void no_of_account_holders()
        {
            Console.WriteLine("state bank has 150 account holders");
        }
        public void Amt_available()
        {
            Console.WriteLine("MARK");
        }
        public void Amt_available(int amt_available)
        {
            Console.WriteLine(amt_available);
        }
        public void contact_details(string email)
        {
            Console.WriteLine(email);
        }
        public void contact_details(int phone_no)
        {
            Console.WriteLine(phone_no);
        }
        public int operation(int a,int b)
        {
           return a + b;
        }
        public double operation(double a, double b)
        {
            return a - b;
        }

    }
}
