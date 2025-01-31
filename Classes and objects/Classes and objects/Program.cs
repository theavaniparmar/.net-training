using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_objects
{
    class Student
    {
        int id;
        string name;

        public void Insert(int a , string b)
        {
            id = a;
            name = b;
        } 
        public void display()
        {
            Console.WriteLine(id + "  " + name);
        }
        static void Main(string[] args)
        {
            Student st = new Student();
            st.Insert(1, "Avani");
            st.display();
            Console.ReadLine();
        }
    }
}
