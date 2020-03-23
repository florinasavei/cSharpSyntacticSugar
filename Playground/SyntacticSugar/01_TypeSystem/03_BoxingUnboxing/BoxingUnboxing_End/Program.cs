using System;

namespace BoxingUnboxing_End
{
    class Program
    {
        static void Main(string[] args)
        {

            int TheNumber = 11;

            // boxing
            object TheBox = (object)TheNumber;

            Console.WriteLine("object to string: " + TheBox.ToString());
            Console.WriteLine(TheBox.GetType());

            // unboxing
            int OutOfTheBox = (int)TheBox;

            TheNumber = Program.Increment(TheNumber);
            OutOfTheBox = Program.Increment(OutOfTheBox);
            TheBox =  Program.Increment(TheBox);

            Program.Print(TheNumber);
            Program.Print(TheBox);
            Program.Print(OutOfTheBox);

        }

        public static int Increment(int a)
        {
            return ++a;
        }

        public static object Increment(object a)
        {
            if (a is int)
            {
               a = (int)a + 1;
            }

            return a;
        }

        public static void Print(object obj)
        {
            Console.WriteLine(obj);
        }
    }
}
