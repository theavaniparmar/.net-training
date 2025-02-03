using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortedsetcollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> list = new SortedSet<int>
            { 1,3,67,56,90,12,23,78,6,9,};

            Console.WriteLine("sorted set elements:");
            foreach(int i in list) 
            {
                Console.WriteLine(i);
            }
            Console.WriteLine($"minimum element:{list.Min}");
            Console.WriteLine($"maximum element:{list.Max}");

            Console.ReadKey();
        }
    }
}
