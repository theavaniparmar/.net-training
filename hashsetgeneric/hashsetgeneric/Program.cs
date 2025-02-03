using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashsetgeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> hs1 = new HashSet<string>();
            hs1.Add("avani");
            hs1.Add("saniya");
            hs1.Add("nil");

            Console.WriteLine("hashset1 elements:");
            foreach (string s in hs1) Console.WriteLine(s);

            HashSet<string> hs2 = new HashSet<string>();
            hs2.Add("abc");
            hs2.Add("avani");
            hs2.Add("pqr");

            Console.WriteLine("hashset2 elements:");
            foreach (string i in hs2) { Console.WriteLine(i); }

            hs1.IntersectWith(hs2);
            Console.WriteLine("after intersection of hashset:");
                foreach (string i in hs1) Console.WriteLine(i);

            Console.ReadKey();

        }
    }
}
