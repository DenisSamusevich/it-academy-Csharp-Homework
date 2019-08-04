using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW03.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int CheckNumber()
            {
                int number;
                while (true)
                {
                    Console.WriteLine("Введите число");
                    string numberString = Console.ReadLine();
                    if (int.TryParse(numberString, out number))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Некоректное значение, попробуйте снова");
                    }
                }
                return number;
            }
            void AdditionTwoNumber()
            {
                Console.WriteLine("Запущен метод сложения двух чисел");
                Console.WriteLine("Введите значение первого числа");
                int number1 = CheckNumber();
                Console.WriteLine("Введите значение второго числа");
                int number2 = CheckNumber();
                int result = number1 + number2;
                Console.WriteLine("Сумма введеных чисел равна - " + result);
            }
            void AdditionTwoNumberCheck()
            {
                Console.WriteLine("Запущен метод сравнения сложения двух чисел");
                Console.WriteLine("Введите значение первого числа");
                int number1 = CheckNumber();
                Console.WriteLine("Введите значение второго числа");
                int number2 = CheckNumber();
                int result = number1 + number2;
                Console.WriteLine("Введите сумму двух введенных чисел");
                int comparisonResult = CheckNumber();
                if (result == comparisonResult)
                {
                    Console.WriteLine("Правильно");
                }
                else
                {
                    Console.WriteLine("Неправильно");
                }
            }
            void AdditionTwoNumberCheckMoreLess()
            {
                Console.WriteLine("Запущен метод сравнения сложения двух чисел с указанием больше/меньше");
                Console.WriteLine("Введите значение первого числа");
                int number1 = CheckNumber();
                Console.WriteLine("Введите значение второго числа");
                int number2 = CheckNumber();
                int result = number1 + number2;
                Console.WriteLine("Введите сумму двух введенных чисел");
                int comparisonResult = CheckNumber();
                if (result == comparisonResult)
                {
                    Console.WriteLine("Правильно");
                }
                else if (result > comparisonResult)
                {
                    Console.WriteLine("Неправильно\nДолжно быть больше");
                }
                else
                {
                    Console.WriteLine("Неправильно\nДолжно быть меньше");
                }
            }
            void AdditionDifferenceTwoNumberCheckMoreLess()
            {
                int result = 0;
                string additionDifferenceString = string.Empty;
                Console.WriteLine("Запущен метод сравнения сложения/вычитания двух чисел с указанием больше/меньше");
                Console.WriteLine("Введите значение первого числа.");
                int number1 = CheckNumber();
                Console.WriteLine("Введите значение второго числа");
                int number2 = CheckNumber();
                while (true)
                {
                    Console.WriteLine("Введите оператор + или -");
                    string operat = Console.ReadLine();
                    if (operat == "+")
                    {
                        Console.WriteLine("Суммируем");
                        result = number1 + number2;
                        additionDifferenceString = "сложения";
                        break;
                    }
                    else if (operat == "-")
                    {
                        Console.WriteLine("Отнимаем");
                        result = number1 - number2;
                        additionDifferenceString = "вычитания";
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Некоректное значение, попробуйте снова.");
                    }
                }
                Console.WriteLine("Введите результат " + additionDifferenceString + " введенных цифр");
                int comparisonResult = CheckNumber();
                if (result == comparisonResult)
                {
                    Console.WriteLine("Правильно");
                }
                else if (result > comparisonResult)
                {
                    Console.WriteLine("Неправильно\nДолжно быть больше");
                }
                else
                {
                    Console.WriteLine("Неправильно\nДолжно быть меньше");
                }
            }

            AdditionTwoNumber();
            AdditionTwoNumberCheck();
            AdditionTwoNumberCheckMoreLess();
            AdditionDifferenceTwoNumberCheckMoreLess();
            Console.WriteLine("Программа выполнена, нажмите Enter для завершения");
            Console.Read();
        }
    }
}
