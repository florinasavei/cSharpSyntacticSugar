using System;
using System.Collections.Generic;
using System.Text;

namespace Operators_End
{
    class Logical
    {
        public void Demo()
        {
            bool a = true, b = false, result;

            // AND operator 
            result = a && b;
            Console.WriteLine("AND Operator: " + result);

            // OR operator 
            result = a || b;
            Console.WriteLine("OR Operator: " + result);

            // NOT operator 
            result = !a;
            Console.WriteLine("NOT Operator: " + result);
        }
    }
}
