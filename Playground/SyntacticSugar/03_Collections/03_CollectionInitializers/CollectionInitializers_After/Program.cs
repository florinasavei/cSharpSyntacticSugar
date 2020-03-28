using System;
using System.Collections.Generic;

namespace CollectionInitializers_After
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Array initializers

            int[] a1 = new int[5];
            int[] a2 = new int[5] { 1, 2, 3, 4, 5 };
            int[] a3 = new int[] { 1, 2, 3, 4, 5 };
            int[] a4 = { 1, 2, 3, 4, 5 };
            var a5 = new int[] { 1, 2, 3, 4, 5 };

            #endregion

            #region Lists
            // Version 1: create a List of ints.
            // ... Add 4 ints to it.
            var numbers = new List<int>();
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(5);
            numbers.Add(7);
            Console.WriteLine("LIST 1: " + numbers.Count);

            // Version 2: create a List with an initializer.
            var numbers2 = new List<int>() { 2, 3, 5, 7 }; //round brackets are not mandatory
            Console.WriteLine("LIST 2: " + numbers2.Count);

            var nesting = new List<List<int>>
            {
                new List<int>
                {
                    1,2,3,
                },
                 new List<int>
                {
                    4,5,6
                },
            };

            #endregion Lists


            #region Dictionary
            // Version 1: create a Dictionary, then add 4 pairs to it.
            var dictionary = new Dictionary<string, int>();
            dictionary.Add("cat", 2);
            dictionary.Add("dog", 1);
            dictionary.Add("llama", 0);
            dictionary.Add("iguana", -1);
            // The dictionary has 4 pairs.
            Console.WriteLine("DICTIONARY 1: " + dictionary.Count);

            // Version 2: create a Dictionary with an initializer.
            var dictionary2 = new Dictionary<string, int>()
            {
                {"cat", 2},
                {"dog", 1},
                {"llama", 0},
                {"iguana", -1}
            };
            // This dictionary has 4 pairs too.
            Console.WriteLine("DICTIONARY 2: " + dictionary2.Count);
            #endregion Dictionary

        }
    }
}
