using System;
using System.Collections.Generic;

namespace GenericList_End
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbers = new List<int>();

            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(5);
            numbers.Add(7);
            numbers.Remove(1);
            numbers.AddRange(new List<int> { 8, 9, 10 });

            var seconEl = numbers[1];

            Console.WriteLine("LIST 1: " + numbers.Count);
        }
    }
}
