using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample
{
    public enum Color
    {
        red=3, green=7, blue=8, pink=6
    }

    public class Test
    {
        public static void Main()
        {
            Color unique = Color.pink;
            Console.WriteLine("unique color is :" + unique);

            int code = (int)unique;
            Console.WriteLine("the value is:" + code);
            Console.ReadLine();
        }
    }
}
