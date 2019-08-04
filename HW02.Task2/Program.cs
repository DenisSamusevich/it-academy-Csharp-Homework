using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW02.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte sbyte1 = 1;
            System.SByte s_sbyte1 = 1;
            Console.WriteLine(sbyte1.GetType());
            Console.WriteLine(s_sbyte1.GetType());
            short short1 = 1;
            System.Int16 s_short1 = 1;
            Console.WriteLine(short1.GetType());
            Console.WriteLine(s_short1.GetType());
            int int1 = 1;
            System.Int32 s_int1 = 1;
            Console.WriteLine(int1.GetType());
            Console.WriteLine(s_int1.GetType());
            long long1 = 1;
            System.Int64 s_long1 = 1;
            Console.WriteLine(long1.GetType());
            Console.WriteLine(s_long1.GetType());
            byte byte1 = 1;
            System.Byte s_byte1 = 1;
            Console.WriteLine(byte1.GetType());
            Console.WriteLine(s_byte1.GetType());
            ushort ushort1 = 1;
            System.UInt16 s_ushort1 = 1;
            Console.WriteLine(ushort1.GetType());
            Console.WriteLine(s_ushort1.GetType());
            char char1 = '1';
            System.Char s_char1 = '1';
            Console.WriteLine(char1.GetType());
            Console.WriteLine(s_char1.GetType());
            uint uint1 = 1;
            System.UInt32 s_uint1 = 1;
            Console.WriteLine(uint1.GetType());
            Console.WriteLine(s_uint1.GetType());
            ulong ulong1 = 'x';
            System.UInt64 s_ulong1 = 'x';
            Console.WriteLine(ulong1.GetType());
            Console.WriteLine(s_ulong1.GetType());
            float float1 = 1;
            System.Single s_float1 = 1;
            Console.WriteLine(float1.GetType());
            Console.WriteLine(s_float1.GetType());
            double double1 = 1;
            System.Double s_double1 = 1;
            Console.WriteLine(double1.GetType());
            Console.WriteLine(s_double1.GetType());
            decimal decimal1 = 1;
            System.Decimal s_decimal1 = 1;
            Console.WriteLine(decimal1.GetType());
            Console.WriteLine(s_decimal1.GetType()); 
            string string1 = "etc";
            System.String s_string1 = "etc";
            Console.WriteLine(string1.GetType());
            Console.WriteLine(s_string1.GetType());
            object object1 = 1;
            System.Object s_object1 = "etc";
            Console.WriteLine(object1.GetType());
            Console.WriteLine(s_object1.GetType());
            Console.Read();
        }
    }
}
