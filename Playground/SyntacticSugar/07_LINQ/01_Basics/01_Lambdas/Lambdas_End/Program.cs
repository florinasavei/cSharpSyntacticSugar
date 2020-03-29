using System;
using System.Linq;

namespace Lambdas_End
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 3, 4, 5 };
            var squaredNumbers = numbers.Select(x => x * x);
            Console.WriteLine(string.Join(" ", squaredNumbers));

        }
    }
}
