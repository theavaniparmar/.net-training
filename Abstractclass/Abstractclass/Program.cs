using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractclass
{
    public abstract class Animal
    {
        
        public abstract void eat();
            
       
        public void sleep()
        {
            Console.WriteLine("animal is sleeping");
        }

    }
    
    public class Dog : Animal
    {
        public override void eat()
        {
            Console.WriteLine(" dog is eating");              
        }
    }

    class Program
    {
        static void Main()
        {
            Animal dog = new Dog();
            dog.eat();
            dog.sleep();
            Console.ReadLine();
        }
    }
}
