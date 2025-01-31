using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static float Average(int a , int b)
        {
            return (a + b) / 2;

        }
        static void Main(string[] args)
        {

            Console.WriteLine(Average(2, 4));
            Console.ReadLine();
        }
    }
}
