using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW07.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] random_numbers = new int[10];
            int[] user_numbers = new int[10];
            int[] total_numbers = new int[10];
            Random random_num = new Random();
            Console.WriteLine("input 10 random numbers");
            for (int i = 0; i < random_numbers.Length; i++)
            {
                random_numbers[i] = random_num.Next(50);
                user_numbers[i] = Convert.ToInt32(Console.ReadLine());
                total_numbers[i] = random_numbers[i] + user_numbers[i];
            }
            Console.WriteLine("\tCalculation result");
            Console.Write("\t№\tRandom numbers\tUser numbers\tTotal numbers\n");
            for (int i = 0; i < random_numbers.Length; i++)
            {
                Console.Write("\t" + (i+1) + "\t\t");
                Console.Write(random_numbers[i] + "\t\t");
                Console.Write(user_numbers[i] + "\t\t");
                Console.Write(total_numbers[i] + "\n");
            }
            Console.Read();
        }
    }
}
