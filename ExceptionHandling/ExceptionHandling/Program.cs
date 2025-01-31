using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, result;
            try
            {
                Console.WriteLine("Enter your first number:");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your second number:");
                b = int.Parse(Console.ReadLine());
                result = a / b;
                Console.WriteLine($"Result: {result}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Message: {ex.Message}");

            }
            Console.ReadLine();
        }
    }
}
