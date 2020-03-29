using System;
using System.Collections.Generic;

namespace ObjectInitializer_End
{
    class Program
    {
        static void Main(string[] args)
        {
            var florin = new Student
            {
                FullName = "Florin Asavei",
                Age = 29,
                ShoeSize = 41,
                Grades = new List<float> {7,8,10,9.5f}
            };

        }
    }
}

