using System;

namespace Tuples_End
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part A: create three-item tuple.
            Tuple<int, string, bool> tuple =
                new Tuple<int, string, bool>(1, "cat", true);

            // Part B: access tuple properties.
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item2);
            Console.WriteLine(tuple.Item3);

            var values = (10, "bird", "plane");
            Console.WriteLine(values);
            Console.WriteLine(values.Item1);
            Console.WriteLine(values.Item2);
            Console.WriteLine(values.Item3);

            //Tuple short syntax
            var unnamed = ("one", "two");
            var named = (first: "one", second: "two");
            Console.WriteLine(named.first);
            Console.WriteLine(named.second);


            //Tuple projection
            var localVariableOne = 5;
            var localVariableTwo = "some text";
            var tuple2 = (explicitFieldOne: localVariableOne, explicitFieldTwo: localVariableTwo);

            (int age, string neme) = (15, "gigi");

            (int, int, int, int, int, int, (int, int)) number = (1,2,3,4,5,6,(7,8)); 

        }
    }
}
