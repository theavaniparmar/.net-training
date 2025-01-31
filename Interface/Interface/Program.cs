using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface Interface1
    {
        
        void display();
    }
    class Second : Interface1
    {
        public void display()
        {
            Console.WriteLine("screen");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Second s = new Second();
            s.display();
            Console.ReadLine();
        }
    }
}
