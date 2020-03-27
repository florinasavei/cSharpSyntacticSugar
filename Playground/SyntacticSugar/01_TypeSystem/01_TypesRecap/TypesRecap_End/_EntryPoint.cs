using System;

namespace TypesRecap_End
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            NumericTypes numericTypes = new NumericTypes();
            numericTypes.NumericDemo();

            DateTimesTest dateTypes = new DateTimesTest();
            dateTypes.DateTimeDemo();

            StringsTest stringTypes = new StringsTest();
            stringTypes.StringDemo();

            BoolTest boolTypes = new BoolTest();
            boolTypes.BoolDemo();

        }
    }
}
