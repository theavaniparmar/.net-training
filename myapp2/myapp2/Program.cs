using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo1;

namespace myapp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 pro = new Class1();
            string msg = pro.Greet();
            Console.WriteLine(msg);
            Console.ReadLine();
        }
    }
}
