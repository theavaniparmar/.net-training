using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Throwexample
{
    class Program
    {
        static void Main(string[] args)
        {
            void CheckAge(int age)
            {
                if (age < 18)
                {
                    throw new Exception("age must be 18 above.");
                }
                Console.WriteLine("successfully done!");
            }
            try
            {
                CheckAge(12);
            }
            catch (Exception ex)
            {

                
                
                Console.WriteLine($"error:{ex.Message}");
                Console.Read();
            }
        }
    }
}
