﻿using System;
using System.Collections.Generic;

namespace Null_coalescing_assignment_End
{
    class Program
    {
        static void Main(string[] args)
        {



            List<int> numbers = null;
            int? z = null;

            (numbers ??= new List<int>()).Add(5);
            Console.WriteLine(string.Join(" ", numbers));  // output: 5

            numbers.Add(z ??= 0);
            Console.WriteLine(string.Join(" ", numbers));  // output: 5 0
            Console.WriteLine(z);  // output: 0

            int? x = null;
            int by = x ?? -1;
            Console.WriteLine(x);


            int? a = null;
            int b;

            //if (a == null)
            //{
            //    b = -1;
            //    a = -1;
            //}
            //else
            //{
            //    b = a.Value;
            //}

            b = a ??= -1;

        }
    }
}
