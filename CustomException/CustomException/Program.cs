using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    public class OddNumberException: Exception
    {
        public override  string Message
        {
            get
            {
                return "Divisor can not be odd number.";
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, result;
            try
            {
                Console.WriteLine("enter first number:");
                number1 = int.Parse(Console.ReadLine());

                Console.WriteLine("enter second number:");
                number2 = int.Parse(Console.ReadLine());

                if (number2 % 2 > 0)
                {
                    OddNumberException e = new OddNumberException();
                    throw new OddNumberException();
                }
                result = number1 / number2;
                Console.WriteLine(result);
            } 
            catch (OddNumberException e)
            {
                Console.WriteLine($"Message: {e.Message}");
            }
            Console.ReadKey();
        }
    }
}
