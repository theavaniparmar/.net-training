using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinallyBlock
{
    class Program
    {
        static void Method1()
        {
            try
            {
                int x, y, z;
                Console.WriteLine("Enter First:");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second:");
                y = int.Parse(Console.ReadLine());
                z = x / y;
                Console.WriteLine($"answer is: {z}");

            }
            finally
            {
                Console.WriteLine("Finally block executed");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Method1();
            }
            catch (Exception)
            {
                Console.WriteLine("exception caught");
            }
            Console.ReadKey();

        }
        
    }
}
