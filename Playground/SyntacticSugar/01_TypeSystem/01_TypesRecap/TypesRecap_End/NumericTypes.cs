using System;
using System.Collections.Generic;
using System.Text;

namespace TypesRecap_End
{
     class NumericTypes
    {
        public  void NumericDemo()
        {
            #region Integer samples
            byte byteNumber = 255;
            sbyte sByteNumber = 127;
            short shortNumber = 32767;
            ushort uShortNumber = 65535;
            int intNumber = 123;
            uint uIntNumber = 4294967290;
            long longNumber = 4294967296;
            ulong uLongNumber = 9223372036854775808;
            #endregion

            #region Char samples
            // Character literal
            char character = 'A';

            // Hexadecimal
            char charAsHexazecimal = '\x0041';

            // Cast from integral type
            char charFromIntCast = (char)65;

            // Unicode
            char charInUnicode = '\u0041';

            Console.WriteLine(character + charAsHexazecimal + charFromIntCast + charInUnicode);
            Console.WriteLine(character + " " + charAsHexazecimal + " " + charFromIntCast + " " + charInUnicode);

            int intValueOfCharacter = (int)character;
            #endregion

            #region Floating point
            // correct
            float floatValueWithSuffix = 3.5F;
            // incorrect
            // float floatValue = 3.5;

            // correct
            double doubleValue = 3; // double is the default floating point type
            double doubleNumber = 3D;

            // correct
            decimal decimalValueWithSuffix = 300.5m;
            // incorrect
            // decimal decimalValue = 300.5;
            #endregion
        }
    }
}
