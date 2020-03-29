using System;
using Microsoft.VisualBasic.CompilerServices;

namespace MethodsRecap_End
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate(7.5f, 4, 6, 45, 7, 5, 7, 54, 54, 4);

            Calculate( a:5, c: 6);
        }

        public static int Calculate(int a, int b = 0, int c = 0)
        {
            return a;
        }

        public static void Calculate(float a, params int[] list)
        {

        }


    }
}
