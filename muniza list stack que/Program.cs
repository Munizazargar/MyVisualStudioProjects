using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace muniza_list_stack_que
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // array_list();
           // stack_function();
            queue_function();
            Console.ReadLine();

        }
        static void array_list()
        {
            ArrayList a = new ArrayList() { "zaid", 111, true, 9.87 };
            foreach (var i in a)
            {
                Console.WriteLine(i);
            }

            //adding
            int[] b = { 1, 2, 3, 4, 5, 6 };
            a.AddRange(b);
            foreach (var i in a)
            {
                Console.WriteLine(i);
            }

            //capacity

            Console.WriteLine(a.Capacity);
            foreach (var i in a)
            {
                Console.WriteLine(i);
            }

            //count
            Console.WriteLine(a.Count);
            foreach (var i in a)
            {
                Console.WriteLine(i);
            }

            //add
            a.Add("zehra");
            foreach (var i in a)
            {
                Console.WriteLine(i);
            }

            //remove
            a.Clear();
            foreach (var i in a)
            {
                Console.WriteLine(i);
            }

            //stack :-A stack is a collection that follows the LIFO (Last In, First Out) principle.
            //This means that the last element added to the stack is the first one to be removed.

            
         
        }
        static void stack_function()
        {
            Stack<int> stack = new Stack<int>();

            //push: Adds an element to the top of the stack.
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            foreach (var i in stack)
            {
                // Console.WriteLine(i);
            }

            //pop: Removes the top element from the stack.
            stack.Pop();
            foreach (var i in stack)
            {
                //Console.WriteLine(i);
            }
            // checking whether the element exist or not
            bool e = stack.Contains(1);
           // Console.WriteLine(e);
            //count clear 


            //peel:: Returns the top element without removing it.

            //  Console.WriteLine(stack.Peek() + " current top item ");
        }
        //2. Queue
        // A queue is a collection that follows the FIFO(First In, First Out) principle.
        //This means that the first element added to the queue is the first one to be removed.
        static void queue_function()
        {
            Queue<int> queue = new Queue<int>();

            //add
            queue.Enqueue(100);
            queue.Enqueue(20000);
            queue.Enqueue(3);

            foreach (var i in queue)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("---------------------------------------------");
            //remove

            Console.WriteLine("---------------------------------------------");

            queue.Dequeue();
            foreach (var i in queue)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("---------------------------------------------");


            //peek
            queue.Peek();
            
        
                Console.WriteLine(queue.Peek ()+"hii");
            

        }
        
    }
}
