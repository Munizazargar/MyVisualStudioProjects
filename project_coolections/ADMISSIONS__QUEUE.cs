using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_coolections
{
    internal class ADMISSIONS__QUEUE
    {
        
        public void inputs()
        {
            
                
                Queue<string> q = new Queue<string>();   
                Stack <string> s = new Stack<string>();
                q.Enqueue("zara");
                q.Enqueue("abid");
                q.Enqueue("moin");
                foreach (var o in q)
                {
                    Console.WriteLine(o+ " this is from q");
                    string A = o;
                    s.Push(A);
                }
                foreach(var item  in s)
                { 
                Console.WriteLine(item+ " this is from stack");
                }
                Console.WriteLine(s.Peek()+ " first to be removed");
                s.Pop();
                Console.WriteLine(s.Peek()+ " 2nd to be removed");
                s.Pop() ;
                Console.WriteLine(s.Peek() + " 3rd to be removed");





        }


    }
}
