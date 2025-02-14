using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANKSTRUCTURE
{
    public class UPI :BANK
    {
        private string upi_id;
        private string upi_pin;
        public string UPI_ID
        {
            set { upi_id = value; }
            get { return upi_id; }
        }
        public string UPI_PIN
        {
            set { upi_pin = value; }
            get { return upi_pin; }
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
