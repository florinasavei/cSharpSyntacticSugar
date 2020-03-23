using System;
using System.Collections.Generic;
using System.Text;

namespace Operators_End
{
    class Bitwise
    {
        public void Demo()
        {
            int x = 5, y = 10, result;

            // Bitwise AND Operator 
            result = x & y;
            Console.WriteLine("Bitwise AND: " + result);

            // Bitwise OR Operator 
            result = x | y;
            Console.WriteLine("Bitwise OR: " + result);

            // Bitwise XOR Operator 
            result = x ^ y;
            Console.WriteLine("Bitwise XOR: " + result);

            // Bitwise AND Operator 
            result = ~x;
            Console.WriteLine("Bitwise Complement: " + result);

            // Bitwise LEFT SHIFT Operator 
            result = x << 2;
            Console.WriteLine("Bitwise Left Shift: " + result);

            // Bitwise RIGHT SHIFT Operator 
            result = x >> 2;
            Console.WriteLine("Bitwise Right Shift: " + result);
        }
    }
}
