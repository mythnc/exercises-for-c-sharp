using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3_printing_quotes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the quote? ");
            var quote = Console.ReadLine();
            Console.Write("Who said it? ");
            var author = Console.ReadLine();

            Console.WriteLine(author + " says, " + "\"" + quote + "\"");

            Console.ReadKey();
        }
    }
}
