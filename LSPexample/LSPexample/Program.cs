using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPexample
{
    public abstract class Shape
    {
        public abstract int Area();
    }

    public class Rectangle : Shape
    {
        public int width { get; set; }
        public int height { get; set; }

        public override int Area()
        {
            return width * height;
        }
    }
    public class Square : Shape
    {
        public int length;
        public override int Area() { return length * length; }
    }
        public class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle
            { width = 5, height = 2 };
            Console.WriteLine($"Area of Rectangle:{rectangle.Area()}");

            Square square = new Square
            { length = 3 };
            Console.WriteLine($"Area of Square: {square.Area()}");

            Console.ReadKey();

        }
    }
}
