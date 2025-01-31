using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number:");
            string num = Console.ReadLine();
            int n = Convert.ToInt32(num);
            
            if (n > 18)
            {
                Console.WriteLine("you can drive ");
                
            }
            else
            {
                Console.WriteLine("you cant drive");
                Console.ReadLine();
            }
        }
    }
}
