using System;
using System.Collections;

namespace ArrayList_End
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arryList1 = new ArrayList();
            arryList1.Add(1);
            arryList1.Add("Two");
            arryList1.Add(3);
            arryList1.Add(4.5f);

            IList arryList2 = new ArrayList()
            {
                100, 200
            };

            //Adding entire collection using ArrayList.AdRange() method.
            ////Note: IList does not contain AddRange() method.
            arryList1.AddRange(arryList2);

            ArrayList myArryList = new ArrayList();
            myArryList.Add(1);
            myArryList.Add("Two");
            myArryList.Add(3);
            myArryList.Add(4.5f);

            //Access individual item using indexer
            int firstElement = (int)myArryList[0]; //returns 1
            string secondElement = (string)myArryList[1]; //returns "Two"
            int thirdElement = (int)myArryList[2]; //returns 3
            float fourthElement = (float)myArryList[3]; //returns 4.5

        }
    }
}
