using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_class
{
    public static class MyMath
    {
        public static float PI = 3.14f;
        public static int cube(int n) { return n * n * n; }
    }
    class TestMyMath
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Value of PI is: " + MyMath.PI);
            Console.WriteLine("Cube of 4 is: " + MyMath.cube(4));
            Console.ReadLine();
        }
    }
}