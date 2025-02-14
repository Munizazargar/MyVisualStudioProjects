using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creditcardproperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            creditcard cc = new creditcard();
            cc.info();

            UPI v = new UPI();
            v.info();   

            Console.ReadLine();
        }
    }
}
