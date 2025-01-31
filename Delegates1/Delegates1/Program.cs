using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates1
{
    public delegate void Delegate(string message);

    public class Class1
    {
       

        public void display(string msg)
        {
            Console.WriteLine($"Message: {msg}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            Delegate del = new Delegate(c1.display);
            del("hello world");
            Console.ReadKey();
        }
    }
}
