using System;
using System.Collections.Generic;

namespace Null_coalescing_assignment_End
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = null;
            int? a = null;

            (numbers ??= new List<int>()).Add(5);
            Console.WriteLine(string.Join(" ", numbers));  // output: 5

            numbers.Add(a ??= 0);
            Console.WriteLine(string.Join(" ", numbers));  // output: 5 0
            Console.WriteLine(a);  // output: 0
        }
    }
}
