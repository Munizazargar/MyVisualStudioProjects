using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstore
{
    public class DVD : LIBRARY
    {
      
        private string DIRECTOR;
        private string DURATION;
        public string director
        {
            set { DIRECTOR = value; }
            get { return DIRECTOR; }
        }
        public string duration
        {
            set { DURATION = value; }
            get { return DURATION; }
        }
        public void info(string topic, string director, string duration, string ids, int da, int c)
        {
            Console.WriteLine(topic + " " + director + " " + duration + " " + ids + " " + da + " " + c);

        }
    }
}
