using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immutability
{
    public class Person
    {
        public string Name { get; }
        public int Age { get;}

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    class Program
    {
       
        
        public static void Main()
        {
            Person person = new Person("avani", 22);
            Console.WriteLine($"Name is:{person.Name}, Age is:{person.Age}");

            Console.ReadLine();

        }
    }
}
