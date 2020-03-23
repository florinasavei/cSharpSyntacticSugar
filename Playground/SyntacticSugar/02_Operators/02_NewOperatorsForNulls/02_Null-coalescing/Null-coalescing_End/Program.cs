using System;
using System.Collections.Generic;

namespace Null_coalescing_End
{
    class Program
    {
        static void Main(string[] args)
        {

            int? a = null;
            int b = a ?? -1;
            Console.WriteLine(b);
        }
    }
}
