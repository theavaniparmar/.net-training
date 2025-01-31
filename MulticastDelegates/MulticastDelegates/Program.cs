using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegates
{
    public delegate void MyDelegate();

    public class MyClass
    {
        public void Method1()
        {
            Console.WriteLine("Method1 is called");
        }

        public void Method2()
        {
            Console.WriteLine("Method2 is called");
        }

        public void Method3()
        {
            Console.WriteLine("Method3 is called");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass c1 = new MyClass();
            MyDelegate del = new MyDelegate(c1.Method1);
            del += c1.Method2;
            del += c1.Method3;

            del();
            Console.ReadKey();

        }
    }
}
