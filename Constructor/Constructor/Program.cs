using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Person
    {
        int id;
        string name;

        public Person(int i, string n)
        {
            id = i;
            name = n;
            Console.WriteLine("parameter constructor called");
        }
        public void display()
        {
            Console.WriteLine($"  id: {id}, \n name: {name}");
        }
    }
     public class main
    {
        static void Main()
        {
            Person p1 = new Person(1, "Avani");
            p1.display();
            Console.ReadLine();
        }
    }
}
