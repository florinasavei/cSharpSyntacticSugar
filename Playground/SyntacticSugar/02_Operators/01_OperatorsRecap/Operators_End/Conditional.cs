using System;
using System.Collections.Generic;
using System.Text;

namespace Operators_End
{
    class Conditional
    {
        public void Demo()
        {
            int x = 5, y = 10, result;

            // To find which value is greater 
            // Using Conditional Operator 
            result = x > y ? x : y;

            // To display the result  
            Console.WriteLine("Result: " + result);

            // To find which value is greater 
            // Using Conditional Operator 
            result = x < y ? x : y;

            // To display the result 
            Console.WriteLine("Result: " + result);
        }
    }
}
