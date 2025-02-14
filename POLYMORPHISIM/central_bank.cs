using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLYMORPHISIM
{
    public abstract class central_bank
    {
        public virtual void no_of_employees()
        {
            Console.WriteLine("central bank has 183 employees");
        }
        public abstract void no_of_account_holders();
        
        
    }
}
