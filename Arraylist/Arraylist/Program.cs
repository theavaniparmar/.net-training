using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Arraylist
{
     public class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            list.Add(1);
            list.Add(true);
            list.Add("abc");
            list.Add('c');
            list.Add(3.14);

            foreach (var i in list)
            {
                Console.WriteLine("Array element:"+i);
            }

            list.AddRange(new object[] { 100, "avani", 6.7 });
            Console.WriteLine(list[6]);
            Console.WriteLine(list.Contains(100));
            Console.WriteLine(list.IndexOf(6.7));

            list[1] = "modify";
            list.Insert(0, 'd');
            Console.WriteLine("\n new   arraylist:");
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }

            list.Remove(3.14);
            Console.WriteLine("\n new   arraylist:");
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }

            ArrayList list1 = new ArrayList() { 2, 8, 5, 9 };
            list1.Sort();
           
            Console.WriteLine("new sorted  arraylist:");
            foreach (var i1 in list1)
            {
                Console.WriteLine(i1);
            }

            list1.Reverse();
            Console.WriteLine("new reverse  arraylist:");
            foreach (var i1 in list1)
            {
                Console.WriteLine(i1);
            }


            Console.ReadLine();
        }
    }
}
