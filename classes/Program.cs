using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    internal class main_class
    {

        static void Main(string[] args)
        {
            demo obj = new demo();
            obj.greet();

            external_class ec = new external_class();
            external_class ec2 = new external_class();
            external_class ec3 = new external_class();

            ec.name = "laveeza";
            ec.phone = "7889766444";
            ec.email = "lavazea@gamil.com";

            ec2.name = "muneeza";
            ec2.phone = "8977987677";
            ec2.email = "muneeza @gmail.com";

            ec3.name = "sayar";
            ec3.phone = "8977977";
            ec3.email = "sayar @gmail.com";


            Console.WriteLine("Name :-"+ec.name + "\nPhone :-"+ec.phone +"\nEmial"+ ec.email);
            Console.WriteLine("Name :-" + ec2.name + "\nPhone :-" + ec2.phone + "\nEmial" + ec2.email);
            Console.WriteLine("Name :-" + ec3.name + "\nPhone :-" + ec3.phone + "\nEmial" + ec3.email);
            Console.ReadLine();
        }


    }

    public class demo
    {

        public void greet()
        {
            Console.WriteLine("hello from external class");
        }

    }

}