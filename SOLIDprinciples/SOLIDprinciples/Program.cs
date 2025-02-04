using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDprinciples
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string City { get; set; }

        public void PrintData()
        {
            Id = 101;
            Name = "avani";
            Description = "Backend Developer";
            City = "Rajkot";
            Console.WriteLine($"Id: {Id}, Name:{Name}, Description:{Description}, City:{City}");
        }
    }

    public class Person1 : Person
    {
        public int Age { get; set; }

        public void AgeCount(int age)
        {
            Age = age;
            if (Age > 18) { Console.WriteLine("you are the adult"); }

            else
            {
                Console.WriteLine("you are a teenager");
            }



        }
        public class Program
        {
            static void Main(string[] args)
            {
                //SRP example
                Person1 person = new Person1();
                person.PrintData();
                person.AgeCount(21);
                Console.ReadKey();


            }
        }
    }
}
