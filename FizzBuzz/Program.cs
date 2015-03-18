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
            var fizzBuzz = new FizzBuzz();

            var inputValues = new Dictionary<int, string> { { 3, "Fizz" }, { 5, "Buzz" } };

            var returnDictionary = fizzBuzz.Run(1, 100, inputValues);

            foreach (var re in returnDictionary)
            {
                Console.WriteLine(re);
            }
        }
    }
}
