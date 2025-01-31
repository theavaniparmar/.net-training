using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innerexception
{
    class Program
    {
        //invalid user input exception
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    string input = "abc";
                    int number = int.Parse(input);


                }
                catch(FormatException FE)
                {
                    throw new Exception("input is not valid.",FE);
                }
                Console.WriteLine("exception is not there.");
            }
            catch(Exception E)
            {
                Console.WriteLine($"Outer Exception: {E.Message}");

                if (E.InnerException != null)
                {
                    Console.WriteLine($"Inner Exception: {E.InnerException.Message}");
                }
               
            }
            Console.ReadKey();
        }
    }
}
