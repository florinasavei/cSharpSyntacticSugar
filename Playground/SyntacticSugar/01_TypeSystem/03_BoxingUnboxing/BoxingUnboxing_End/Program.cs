using System;

namespace BoxingUnboxing_End
{
    class Program
    {
        static void Main(string[] args)
        {
            //casting example
            double x = 7.5;
            int y = (int)x;


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


            var result = Program.Increment(7.5);
            double? restul2 = result as double?;
        }

        public static int Increment(int a)
        {
            return ++a;
        }

        //public static double Increment(double a)
        //{
        //    return ++a;
        //}

        public static object Increment(object a)
        {
            if (a is int)
            {
               a = (int)a + 1;
            }

            if (a is double)
            {
                a = (double)a * 2;
            }

            return a;
        }

        public static void Print(object obj)
        {
            string theType = obj.GetType().ToString();

            Console.WriteLine($"The type is: {theType}, the values is {obj}");
        }
    }
}
