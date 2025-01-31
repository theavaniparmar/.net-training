using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodoverloading
{
    public class Sum
    {
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        public int Add(int a , int b)
        {
            return a + b;
        }
            
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sum s = new Sum();
            Console.WriteLine("sum is:" + s.Add(1, 2));
            Console.WriteLine("sum is:" + s.Add(1, 2, 5));
            Console.ReadLine();

        }
    }
}
