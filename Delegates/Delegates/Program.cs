using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        public delegate void Display(string message);
        static void Main(string[] args)
        {
            Display disc = Show;
            disc("hello");
            Console.ReadLine();
            
        }
        public static void Show(string message)
        {
            Console.WriteLine("message:" + message);
        }
    }
}
