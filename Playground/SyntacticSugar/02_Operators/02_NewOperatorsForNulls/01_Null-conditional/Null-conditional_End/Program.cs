using System;
using System.Collections.Generic;

namespace Null_conditional_End
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> someNumbers = null;

            int? length1 = (someNumbers != null) ? (int?)someNumbers.Count : null;

            int? length2 = someNumbers?.Count; // null if people is null

            //company?.empoyee?.address?.stretname
        }
    }
}
