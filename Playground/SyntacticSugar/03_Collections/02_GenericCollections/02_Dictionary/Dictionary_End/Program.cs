using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary_End
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "One");
            dict.Add(2, "Two");
            dict.Add(3, "Three");
            

            for (int i = 0; i < dict.Count; i++)
            {
                Console.WriteLine("Key: {0}, Value: {1}",
                    dict.Keys.ElementAt(i),
                    dict[dict.Keys.ElementAt(i)]);
            }
        }
    }
}
