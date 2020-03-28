using System;
// example from https://www.geeksforgeeks.org/local-function-in-c-sharp/
using System.IO;

namespace LocalMethods_End
{
    class Program
    {
        // Main method 
        public static void Main()
        {

            // Local Generic Function 
            void MyMethod<MyValue>(MyValue value)
            {
                Console.WriteLine("Value is: " + value);
            }

            // Calling local generic function 
            MyMethod<int>(123);
            MyMethod<string>("GeeksforGeeks");
            MyMethod<char>('G');
            MyMethod<double>(45453.5656);
        }

    }
}
