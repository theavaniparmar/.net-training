using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashcollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            ht.Add(1, "avani");
            ht.Add(2, "saniya");
            ht.Add(3, "nil");

            Console.WriteLine("hashtable elements:");

            foreach (DictionaryEntry entry in ht)
            {
                Console.WriteLine($"key: {entry.Key} value: {entry.Value}");
            }

            ht.Remove(3);
            ht.Add(4, "yatri");

            ht.ContainsKey(2);
            ht.ContainsValue("avani");

            Console.WriteLine("\n accessing element 1:" + ht[1]);
            Console.WriteLine("\n\n updated table:");
            foreach (DictionaryEntry entry in ht)
            {
                Console.WriteLine($"key: {entry.Key} value: {entry.Value}");
            }

            Console.ReadKey();

        }
    }
}
