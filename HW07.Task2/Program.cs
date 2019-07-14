using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW07.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] user_numbers = new int[10];
            int[] copy_numbers = new int[10];
            int index_number;
            Console.WriteLine("input 9 random numbers");
            for (int i = 0; i < user_numbers.Length-1; i++)
                user_numbers[i] = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < user_numbers.Length; i++)
                Console.Write("\t"+user_numbers[i]);
            Console.WriteLine("\ninput index from 0 to 9");
            index_number = Convert.ToInt32(Console.ReadLine());
            Array.Copy(user_numbers, 0, copy_numbers, 0 , index_number);
            Array.Copy(user_numbers, index_number, copy_numbers, index_number + 1, 9 - index_number);
            Console.WriteLine("input random number");
            copy_numbers[index_number] = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < user_numbers.Length; i++)
            {
                Console.Write("\t" + copy_numbers[i]);
            }
            Console.Read();
        }
    }
}
