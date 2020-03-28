using System;

namespace WorkingWithNulls
{
    class Program
    {
        static void Main(string[] args)
        {
            // this will give compile time error
            //int j = null;

            // Valid declaration
            Nullable<int> j = null;

            // Valid declaration
            int? k = null;

            // defining Nullable type 
            Nullable<int> n = null;

            // using the method 
            // output will be 0 as default  
            // value of null is 0 
            Console.WriteLine(n.GetValueOrDefault());

            // a is nullable type 
            // and contains null value 
            Nullable<int> a = null;

            // check the value of object 
            Console.WriteLine(a.HasValue);

            //now b has a value so we can access its Value property
            int? b = 7;
            Console.WriteLine(b.Value);

        }
    }
}
