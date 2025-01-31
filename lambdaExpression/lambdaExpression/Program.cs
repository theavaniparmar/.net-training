using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambdaExpression
{
    public delegate int Math(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            Math add = (x, y) => x + y;
            Console.WriteLine("addition:" +add(5,3));
            Console.ReadKey();
        }
    }
}
