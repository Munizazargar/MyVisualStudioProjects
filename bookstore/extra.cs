using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstore
{
    public class animal
    {
        public void eats()
        {
            Console.WriteLine("it eats");
        }
        public void sleeps()
        {
            Console.WriteLine("it sleeps");
        }
        public virtual void sound()
        {
            Console.WriteLine("it makes sound");
        }
    }
    public class cat : animal 
    {
        public void name()
        {
            Console.WriteLine("it has a name");

        }
        public override void sound()
        {
            Console.WriteLine("it meows");

        }
    }
}
