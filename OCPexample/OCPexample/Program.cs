using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPexample
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }
        public abstract double CalBonus();
    }

    public class Manager : Employee
    {
        public Manager(string name, double salary) : base(name, salary) { }

        public override double CalBonus()
        {
            return Salary * 0.3; //30% bonus
        }
    }

    public class Developer : Employee
    {
        public Developer(string name, double salary) : base(name, salary) { }

        public override double CalBonus()
        {
            return Salary * 0.2; //20% bonus
        }
    }
    public class Designer : Employee
    {
        public Designer(string name, double salary) : base(name, salary) { }

        public override double CalBonus()
        {
            return Salary * 0.1; //10% bonus
        }
    }



    public class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
           { new Manager("Avani", 50000),
             new Developer("Saniya", 40000),
             new Designer("Aman", 20000)
            };

            foreach (Employee employee in employees)
            {
                Console.WriteLine($"Employee Name:{employee.Name},Employee Salary: {employee.Salary},Bonus: {employee.CalBonus()}");
                
            }
            Console.ReadKey();
        }
    }
}
