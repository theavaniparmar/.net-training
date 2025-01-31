using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplecatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, div;
            try
            {


                Console.WriteLine("Enter your first number:");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your Second number:");
                num2 = int.Parse(Console.ReadLine());
                div = num1 / num2;
                Console.WriteLine($"answer is: {div}");
            }
            catch (DivideByZeroException DBZE)
            {
                Console.WriteLine("second number should not be zero.");
            }
            catch(FormatException FE)
            {
                Console.WriteLine("enter number in valid format. ");

            }
            catch(Exception E)
            {
                Console.WriteLine("generic catch block.");
            }
            Console.ReadLine();
        }
    }
}
