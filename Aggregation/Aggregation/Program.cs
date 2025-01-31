using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation
{
    public class Engine
    {
        public string Model { get; set; }

        public void start()
        {
            Console.WriteLine("engine started");
        }
    }
    public class Car
    {
        public string Color { get; set; }
        public Engine CarEngine { get; set; }

        public Car(string color, Engine engine)
        {
            Color = color;
            CarEngine = engine;
        }
        public void startcar()
        {
            Console.WriteLine("car started");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Engine E = new Engine { Model = "abc" };
            Car c = new Car("white", E);
            c.startcar();
            Console.ReadLine();

        }
    }
}
