using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletonclass
{
    public class Singleton
    {
        private Singleton() { }
        private static Singleton instance;
        private static Singleton Instance
        {
            get
            { 
                if (instance == null)
                {
                    instance = new Singleton();
                }

                return instance;
            }
        }
        public void show()
        {
            Console.WriteLine("showing...");
        }
    } 
    class Program
    {
        static void Main(string[] args)
        {
            Console.Read();
            
        }
    }
}
