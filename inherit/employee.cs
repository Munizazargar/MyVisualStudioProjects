using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inherit
{

    public class Employee : manager
    {
        static private int exp;
        public int Exp
        {
            set { exp = value; }
            get { return exp; }
        }
        static private int amount;
        public int Amount
        {
            set { amount = value; }
            get { return amount; }
        }
        public void salary()
        {
            
            exp = 3;
            amount = 10000;
            int salary = Exp * amount;
            Console.WriteLine( salary);
         

        }
        


    }

    

}
