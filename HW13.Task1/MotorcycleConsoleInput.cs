using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW13.Task1
{
    class MotorcycleConsoleInput
    {
        internal static int InputConsoleWidthColumn(string columnName, int minNumber, int maxNumber)
        {
            Console.WriteLine("Введите ширину колонки \"{0}\", минимум " + minNumber.ToString() + ", максимум " + maxNumber.ToString(), columnName);
            return InputConsoleNumber(minNumber, maxNumber);
        }
        internal static int InputConsoleNumberId(int minId,int maxId)
        {
            Console.WriteLine("Введите номер ID");
            return CheckNumber(minId, maxId);
        }
        internal static int InputConsoleNumberIdUpdate(int minId, int maxId)
        {
            Console.WriteLine("Введите номер ID экземпляра который хотите заменить");
            return CheckNumber(minId,maxId);
        }
        internal static int InputConsoleNumberIdDelete(int minId, int maxId)
        {
            Console.WriteLine("Введите номер ID экземпляра который хотите удалить");
            return CheckNumber(minId,maxId);
        }
        internal static int InputConsoleNumber(int minNumber, int maxNumber)
        {
            Console.Write("Введите число - ");
            return CheckNumber(minNumber, maxNumber);
        }
        internal static string InputConsoleName(int maxChar)
        {
            int cursorInputLeft = Console.CursorLeft;
            int cursorInputTop = Console.CursorTop;
            Console.WriteLine();
            Console.Write("Введите имя мотоцикла        ");
            Console.SetCursorPosition(cursorInputLeft, cursorInputTop);
            return CheckString(maxChar);
        }
        internal static string InputConsoleModel(int maxChar)
        {
            int cursorInputLeft = Console.CursorLeft;
            int cursorInputTop = Console.CursorTop;
            Console.WriteLine();
            Console.Write("Введите модель мотоцикла      ");
            Console.SetCursorPosition(cursorInputLeft, cursorInputTop);
            return CheckString(maxChar);
        }
        internal static int InputConsoleYear(int minYear, int maxYear, int maxChar)
        {
            int cursorInputLeft = Console.CursorLeft;
            int cursorInputTop = Console.CursorTop;
            Console.WriteLine();
            Console.Write("Введите год мотоцикла         ");
            Console.SetCursorPosition(cursorInputLeft, cursorInputTop);
            return CheckNumber(minYear, maxYear, maxChar, '|');
        }
        internal static int InputConsoleOdometer(int minOdometer, int maxOdometer, int maxChar)
        {
            int cursorInputLeft = Console.CursorLeft;
            int cursorInputTop = Console.CursorTop;
            Console.WriteLine();
            Console.Write("Введите пробег мотоцикла      ");
            Console.SetCursorPosition(cursorInputLeft, cursorInputTop);
            return CheckNumber(minOdometer, maxOdometer, maxChar, '|');
        }
        static int CheckNumber()
        {
            return CheckNumber(int.MinValue, int.MaxValue);
        }
        static int CheckNumber(int minNumber,int maxNumber, int maxChar = 5,char fixTable = char.MinValue)
        {
            int number;
            int cursorInputLeft = Console.CursorLeft;
            int cursorInputTop = Console.CursorTop;
            while (true)
            {
                string numberString = Console.ReadLine();
                if (int.TryParse(numberString, out number)&& minNumber<= number && maxNumber >= number)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Некоректное значение, попробуйте снова");
                    Console.SetCursorPosition(cursorInputLeft, cursorInputTop);
                    Console.Write(new string(' ', maxChar-1));
                    Console.Write(fixTable);
                    Console.SetCursorPosition(cursorInputLeft, cursorInputTop);
                }
            }
            Console.WriteLine(new string(' ', 40));
            Console.SetCursorPosition(cursorInputLeft, cursorInputTop);
            if (fixTable== char.MinValue)
            {
                Console.WriteLine();
            }
            return number;
        }
        static string CheckString(int maxChar)
        {
            string inputString = string.Empty;
            int cursorInputLeft = Console.CursorLeft;
            int cursorInputTop = Console.CursorTop;
            while (true)
            {
                inputString = Console.ReadLine();
                if (inputString.Length<= maxChar)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Некоректное значение, попробуйте снова");
                    Console.SetCursorPosition(cursorInputLeft, cursorInputTop);
                    Console.Write(new string(' ', maxChar-1));
                    Console.Write("|");
                    Console.SetCursorPosition(cursorInputLeft, cursorInputTop);
                }
            }
            Console.WriteLine(new string(' ', 40));
            Console.SetCursorPosition(cursorInputLeft, cursorInputTop);
            return inputString;
        }
    }
}
