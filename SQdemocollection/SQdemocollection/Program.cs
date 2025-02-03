using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SQdemocollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //stack
            Stack stack = new Stack();

            stack.Push(12);
            stack.Push(13); 
            stack.Push(66.7);
            stack.Push(15);
            stack.Push('e');
            stack.Push("person");

            Console.WriteLine($"stack elements: {stack.Count}");

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            stack.Pop();

            Console.WriteLine($"\n after deletion : {stack.Count}");

            Console.WriteLine($"the topmost element is: {stack.Peek()}");


            //queue
            Queue queue = new Queue();

            queue.Enqueue( 1 );
            queue.Enqueue( 2 );
            queue.Enqueue( 3 );
            queue.Enqueue( 4 );
            queue.Enqueue( 5 );

            Console.WriteLine($"\n\n\n queue elements:{ queue.Count}");
            foreach( var item in queue)
            {
                Console.WriteLine(item);
            }

            queue.Dequeue();
            Console.WriteLine($"after deletion:{queue.Count}");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            object[] queueCopy = new object[5];
            queue.CopyTo(queueCopy, 0);
            Console.WriteLine("\nQueue Copy Array Elements:");
            foreach (var item in queueCopy)
            {
                Console.WriteLine(item);
            }




        }
    }
}
