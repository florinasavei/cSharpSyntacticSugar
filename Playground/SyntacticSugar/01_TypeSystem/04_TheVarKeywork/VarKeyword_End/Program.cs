﻿using System;

namespace VarKeyword_End
{
    class Program
    {
        static void Main(string[] args)
        {
            // int value  
            var age = 25;
            Console.WriteLine("var holds an int = {0}", age);
            // string value  
            var name = "Mahesh Chand";
            Console.WriteLine("var holds a string = {0}", name);

            //age = "test" //does not work because age stores an int now;

            //var anything;// does not work because implicit types must be initialized

        }
    }
}
