using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulationoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            addition addition = new addition();
            addition.set_a(2);
            addition.set_b(3);
            Console.WriteLine(addition.get_a());
            Console.WriteLine(addition.get_b());
            Console.WriteLine(addition.get_c());
            Console.ReadLine();
        }
    }
    class addition
    {
        private int a;
        private int b;
        private int c;
        public void set_a(int a)
        {
            this.a = a;
        }
        public int get_a()
        {
            return this.a;
        }
        public void set_b(int b)
        {
            this.b = b;
        }
        public int get_b()
        {
            return (this.b);
        }
        public int get_c()
        {
            c = a + b;
            return c;
        }
    }
}
