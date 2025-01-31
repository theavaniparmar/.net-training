using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Car
    {
        private string carcolor;
        public string Carcolor
        {
            get 
            { 
                return carcolor;
            }
            set
            {
                carcolor = value;
            }
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Car swift = new Car();
            swift.Carcolor = "black";
            Console.WriteLine(" This car have color: " + swift.Carcolor);
            Console.ReadLine();
        }
    }
}
