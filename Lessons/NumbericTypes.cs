using System;
namespace Classwork.lessons
{
    public class NumbericTypes
    {
        /*integral - Signed
        range -128 to 127 */

        sbyte _mysbytevalue = 2;
        //range -32,768 to  32767
        short _myshortvalue = 4;

        //range -2,147,483,648 to 2,147,483,647
        int _myintvalue = 25000;

        // -9,223,372,036,854,775,808 to -9,223,372,036,854,775,807
        long _myLongvalue = 1_234_567L;
        long _myLongvalue2 = 0x5F;
        // integral  - unsigned 
        // range 0 to 225
        byte _myBytetValue = 3;

        // range 0 to 65,535
        ushort _myUshortValue = 35;

        // range 0 to 4,294,967,295
        uint _myUInt = 2345U;
        // range 0 to 18,446,744,073709,551,615
        ulong _myULongValue = 123456UL;
        // real numbers 
        // Range 3.4E +/- 38(7 digits)
        float _myFloatValue = 123.6589F;
        //Range 1.7E +/- 308(15 digits)
        double _myDoubleValue = 12.34;
        double _myDoubleValue2 = 1E06;

        // range -7.9228E+24 to -7.9228E+24
        decimal MyDecimalValue = 13.234M;

        // Type inference; the getType method returnes the variable type.
        public void Getsometype()
        {
            //double
            Console.WriteLine(3.0.GetType());
            // float
            Console.WriteLine(_myFloatValue.GetType());
        }
        // Method to demonstrate an explicit cast from float to int.
        public int ConvertFloatToInt(float Value)
        {
            int total = (int)Value;
            return total;
        }

        public long LongFromInt(int value)
        {
           long  total= value;
           return total;
        }

    }
}