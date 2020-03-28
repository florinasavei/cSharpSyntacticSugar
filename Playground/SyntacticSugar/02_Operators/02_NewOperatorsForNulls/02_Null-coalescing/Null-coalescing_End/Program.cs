using System;
using System.Collections.Generic;

namespace Null_coalescing_End
{
    class Program
    {
        static void Main(string[] args)
        {

            int? a = null;
  

            int b;

            if (a == null)
            {
                b = -1;
            }
            else
            {
                b = a.Value;
            }

            b = a ?? -1;

            Console.WriteLine(b);
        }
    }
}
