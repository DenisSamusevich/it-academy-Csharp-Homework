using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW02.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte num1 = 5;
            short num2;
            long num3;
            float num4;
            double num5 = 4332.2564;
            double num6;

            num4 = (float)num5;
            num3 = (long)num4;
            num2 = (sbyte)(int)num3;

            num2 = num1;
            num3 = num2;
            num4 = num3;

            object doublenum = num5; //boxing
            num6 = (double)doublenum; //unboxing
        }
    }
}
