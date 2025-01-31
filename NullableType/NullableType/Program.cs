using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableType
{
    class Program
    {
        static void Main(string[] args)
        {
            int? b = 20;
            Console.WriteLine(b);

            if (b == null)
            {
                Console.WriteLine("value is null");

            }
            else Console.WriteLine(b.HasValue);

            int? a = null;
            Console.WriteLine(a);

            if (a == null)
            {
                Console.WriteLine("value is null");

            }
            else Console.WriteLine(a.HasValue);

            Console.ReadLine();
            
           

        }
        
    }
}
