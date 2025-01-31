using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Program
    {
        //call by value ex
        public void Mul(int a)
        {
            a = a * 3;
            Console.WriteLine(a);
        }
        //passing arr to functions
        static void printmin(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            Console.WriteLine(" minimum element is:" + min);
        }
        static void Main(string[] args)
        {
            int a = 4;
            Program p = new Program();

            p.Mul(a);

            int[] array = { 1, 2, 3, 4, 5 };

            printmin(array);
            Console.ReadLine();
            
        }

        
    }
}
