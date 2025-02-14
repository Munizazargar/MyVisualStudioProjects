using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace averagearray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers ={ 1, 2, 3, 4, 5,};
            int sum = 0;
            int average;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }
            Console.WriteLine("SUM OF ELEMENTS = "+ sum);
            Console.WriteLine("NUMBER OF ELEMENTS = " + numbers.Length);
            Console.WriteLine(" AVERAGE OF THE NO'S IN ABOVE ARRAY = SUM OF ELEMENTS/ NO OF ELEMENTS");
            Console.WriteLine(average = sum / numbers.Length );



            Console.ReadLine();
        }
    }
}
