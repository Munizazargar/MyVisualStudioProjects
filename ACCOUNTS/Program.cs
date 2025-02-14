using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACCOUNTS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ACCOUNT <string> a = new ACCOUNT<string>();
            a.set_acc_no("account no = 1235");
            a.set_acc_type("account type = savings");
            Console.WriteLine(a.get_acc_no());
            Console.WriteLine(a.get_acc_type());
            Console.WriteLine(a.Acc_name = "account name = laveezah");
            Console.WriteLine(a.Balance = "account balance = 3000");
            ACCOUNT<int> b = new ACCOUNT<int>();
            

            a.confirmation();
            
            Console.ReadLine();
        }
    }
}
