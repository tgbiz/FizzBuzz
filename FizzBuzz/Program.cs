using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Be sure to get the indices right. 1 to 100,
            // not 0 to 100, or 0 to 99.
            for (int index = 1; index <= 100; index++)
            {
                // Start with the most specialized case, 
                // and chain less specialized cases after it,
                // down until the most general case.
                if (index % 3 == 0 && index % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (index % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (index % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(index);
                }
            }

            Console.ReadKey();

        }
    }
}
