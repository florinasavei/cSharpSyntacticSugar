using System;
using ExtensionMethods_End.CustomExtensions;

namespace ExtensionMethods_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "  I'm    wearing the   cheese.  It isn't wearing me!   ";
            text = text.TrimAndReduce().ToLower();

        }
    }
}
