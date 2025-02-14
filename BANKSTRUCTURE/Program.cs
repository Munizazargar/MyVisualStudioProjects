using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANKSTRUCTURE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CREDIT C= new CREDIT();

            Console.WriteLine(C.Acc_no = "Acc_no = 1234");
            Console.WriteLine(C.Acc_name = "Acc_name = QWERTY");
            Console.WriteLine(C.Acc_balance = "Acc_balance =10000");

            C.proces_payment();
            C.get_receipt();

            Console.WriteLine(C.CC_NO = "CC_NO = 3333");
            Console.WriteLine(C.CC_pin = "CC_pin =6543");




            Console.ReadLine();
        }
    }
}
