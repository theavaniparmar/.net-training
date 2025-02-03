using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Employeedetails
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }

    }
    public class Program
    {
        static void Main(string[] args)
        {

            {
                Employee employee1 = new Employee() { Id = 102, Name = "laksh", Department = "frontend", Salary = 30000 };
                Employee employee2 = new Employee() { Id = 101, Name = "yash", Department = "backend", Salary = 50000 };
                Employee employee3 = new Employee() { Id = 104, Name = "janvi", Department = "QA", Salary = 10000 };
                Employee employee4 = new Employee() { Id = 103, Name = "radhika", Department = "HR", Salary = 25000 };


                List<Employee> list = new List<Employee>();
                list.Add(employee1);
                list.Add(employee2);
                list.Add(employee3);
                list.Add(employee4);

                List<Employee> sortedList = list.OrderBy(e => e.Id).ToList();

                
                Console.WriteLine("list Employee Records:");
                foreach (Employee emp in sortedList)
                {
                    Console.WriteLine($"Id: {emp.Id}, Name:{emp.Name}, Department:{emp.Department}, Salary:{emp.Salary}");
                }
            }
        }
    }
}
