using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANKSTRUCTURE
{
    sealed public class CREDIT:BANK
    {
        private string cc_no;
        private string cc_pin;
        public string CC_NO
        {
            set { cc_no = value; }
            get { return cc_no; }
        }
        public string CC_pin
        {
            set { cc_pin = value; }
            get { return cc_pin; }
        }
        public override void proces_payment()
        {
            Console.WriteLine("payment is processed");
        }
        public override void get_receipt()
        {
            Console.WriteLine("print receipt");
        }
    }
}
