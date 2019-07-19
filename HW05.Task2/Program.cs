using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW05.Task2
{
    class Program
    {

        static void Main(string[] args)
        {
            string Exponentiation(uint exponentiation, uint[] start_overflow, bool start_recursion)
            {
                uint[] overflow = new uint[exponentiation];
                string number = " ";
                uint row_number = (uint)(start_recursion ? 1 : 0);
                uint counter = 0;
                uint control;
                if (start_recursion)
                    row_number = 1;
                else
                    row_number = 0;
                for (uint i = 0; i < exponentiation; i++)
                {
                    control = i;
                    row_number = row_number * 2 + start_overflow[i];
                    if (row_number >= 1000000000)
                    {
                        if (counter == 0)
                            counter = i;
                        row_number -= 1000000000;
                        overflow[i - counter] = 1;
                    }
                    else if (counter != 0)
                        overflow[i - counter] = 0;
                }
                if (counter == 0)
                    return number = Convert.ToString(row_number);
                else
                    return number = Exponentiation(exponentiation - counter, overflow, false) + row_number;
            }

            uint time_minute = 0;
            Console.WriteLine("Input the time in minutes (At one's own risk)");
            time_minute = Convert.ToUInt32(Console.ReadLine());
            uint[] initial_overflow = new uint[time_minute];
            Console.WriteLine("Cell count " + Exponentiation(time_minute, initial_overflow, true));
            Console.ReadLine();
        }
    }
}
