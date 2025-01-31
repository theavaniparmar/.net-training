using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodExample
{
    public static class Extensions
    {
        public static bool Check(this string input, string word)
        {
            if (string.IsNullOrEmpty(input) || string.IsNullOrEmpty(word))
                return false;

            return input.Contains(word);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = "my garden is very beautiful.";
            string word1 = "have";

            bool result = input1.Contains(word1);
            Console.WriteLine(result);

            string input2 = "my garden is very beautiful.";
            string word2 = "very";

            bool result1 = input2.Contains(word2);
            Console.WriteLine(result1);

            Console.ReadLine();
        }
    }
}
