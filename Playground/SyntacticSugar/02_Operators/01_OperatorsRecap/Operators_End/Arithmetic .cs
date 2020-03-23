using System;
using System.Collections.Generic;
using System.Text;

namespace Operators_End
{
    class Arithmetic
    {
        public void Demo()
        {

            int result;
            int x = 10, y = 5;

            // Addition 
            result = (x + y);
            Console.WriteLine("Addition Operator: " + result);

            // Subtraction 
            result = (x - y);
            Console.WriteLine("Subtraction Operator: " + result);

            // Multiplication 
            result = (x * y);
            Console.WriteLine("Multiplication Operator: " + result);

            // Division 
            result = (x / y);
            Console.WriteLine("Division Operator: " + result);

            // Modulo 
            result = (x % y);
            Console.WriteLine("Modulo Operator: " + result);

            int a = 10, res;

            // post-increment example: 
            // res is assigned 10 only,  
            // a is not updated yet 
            res = a++;

            //a becomes 11 now 
            Console.WriteLine("a is {0} and res is {1}", a, res);


            // post-decrement example: 
            // res is assigned 11 only, a is not updated yet 
            res = a--;

            //a becomes 10 now 
            Console.WriteLine("a is {0} and res is {1}", a, res);


            // pre-increment example: 
            // res is assigned 11 now since a 
            // is updated here itself 
            res = ++a;

            // a and res have same values = 11 
            Console.WriteLine("a is {0} and res is {1}", a, res);


            // pre-decrement example: 
            // res is assigned 10 only since 
            // a is updated here itself 
            res = --a;

            // a and res have same values = 10 
            Console.WriteLine("a is {0} and res is {1}", a, res);
        }
    }
}
