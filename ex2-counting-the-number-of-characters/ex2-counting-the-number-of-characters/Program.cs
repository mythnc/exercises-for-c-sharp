using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_counting_the_number_of_characters
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = GetInputString();
            while (input.Length == 0)
            {
                Console.WriteLine("You must enter something");
                input = GetInputString();
            }

            var len = input.Length;
            Console.Write("{0} has {1} character", input, len);
            if (len > 1)
            {
                Console.Write("s");
            }
            Console.WriteLine(".");

            Console.ReadKey();
        }

        static String GetInputString()
        {
            Console.Write("What is the input string? ");
            return Console.ReadLine();
        }
    }
}
