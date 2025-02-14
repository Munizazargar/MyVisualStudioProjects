using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLYMORPHISIM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            state_bank state_Bank = new state_bank();



            Console.WriteLine(state_Bank.operation(44, 33));
            Console.WriteLine(state_Bank.operation(44.0, 33.0));



            Console.ReadLine();
        }


    }
}
