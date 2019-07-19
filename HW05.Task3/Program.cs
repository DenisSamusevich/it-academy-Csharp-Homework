using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW05.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Month = 0;
            double increase = 0;
            double Deposit_amount = 1000;
            double percent = 1.02;
            Console.WriteLine("Input the number of months");
            int number_of_months = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Month\tincrease\tdeposit amount");
            for (int i = 0; i < number_of_months; i++)
            {
                Month = i + 1;
                Deposit_amount = Deposit_amount*percent;
                increase = Deposit_amount * percent - Deposit_amount;
                Console.WriteLine(Month+"\t"+Math.Round(increase,2) +"\t\t"+Math.Round(Deposit_amount,2));
            }
            Console.Read();
        }
    }
}
