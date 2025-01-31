using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Array
    {
        static void Main(string[] args)
        {
            char[] arr = { 'a', 'b', 'c', 'd', 'e' };

            Console.WriteLine("3rd element is:" + arr[2]);
            Console.WriteLine("5th element is:" + arr[4]);

            arr[0] = 'g';
            Console.WriteLine("after changing 1st element is:" + arr[0]);

            Console.WriteLine(" length of array:" + arr.Length);

            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
                
            }

            //multidimensional array
            int[,] square = new int[2, 2] { { 4, 5 }, { 6, 7 } };
            Console.WriteLine(square[1, 1]);
            Console.ReadLine();

            
        }
    }
}
