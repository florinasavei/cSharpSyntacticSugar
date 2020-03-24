using System;

namespace RangeOperator_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] techArray = { "C", "C++", "C#", "F#", "JavaScript", "Angular", "TypeScript", "React", "GraphQL" };

            foreach (var item in techArray[1..4])
            {
                Console.WriteLine(item);  //C++ C# F#
            }
        }
    }
}
