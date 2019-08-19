using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace HW13.Task1
{
    class MotorcycleConsoleWrite
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(MotorcycleConsoleWrite));
        static int CurcorId { get; } = 2;
        static int CurcorName { get; }
        static int CurcorModel { get; }
        static int CurcorYear { get; }
        static int CurcorOdometer { get; }
        static int WidthMinId { get; } = 4;
        static int WidthMinName { get; } = 10;
        static int WidthMinModel { get; } = 11;
        static int WidthMinYear { get; } = 6;
        static int WidthMinOdometer { get; } = 5;
        static int WidthId { get; }
        static int WidthName { get; }
        static int WidthModel { get; }
        static int WidthYear { get; }
        static int WidthOdometer { get; }
        static int WidthTable { get; }
        static int WidthMaxName { get; } = 30;
        static int WidthMaxModel { get; } = 30;
        static int WidthMaxYear { get; } = 10;
        static int WidthMaxOdometer { get; } = 10;
        static MotorcycleConsoleWrite()
        {
            Console.WriteLine("Для работы коллекции необходимо задать параметры таблицы");
            WidthId = MotorcycleDataBase.MaxNumberCollection.ToString().Length + 2 > WidthMinId ? MotorcycleDataBase.MaxNumberCollection.ToString().Length + 2 : WidthMinId;
            WidthName = MotorcycleConsoleInput.InputConsoleWidthColumn("Имя", WidthMinName, WidthMaxName);
            WidthModel = MotorcycleConsoleInput.InputConsoleWidthColumn("Модель", WidthMinModel, WidthMaxModel);
            WidthYear = MotorcycleConsoleInput.InputConsoleWidthColumn("Год", WidthMinYear, WidthMaxYear);
            WidthOdometer = MotorcycleConsoleInput.InputConsoleWidthColumn("Пробег", WidthMinOdometer, WidthMaxOdometer);
            CurcorName = 1 + WidthId + 1;
            CurcorModel = CurcorName + WidthName + 1;
            CurcorYear = CurcorModel + WidthModel + 1;
            CurcorOdometer = CurcorYear + WidthYear + 1;
            WidthTable = 1 + WidthId + 1 + WidthName + 1 + WidthModel + 1 + WidthYear + 1 + WidthOdometer + 1;
            Console.WriteLine("Параметры таблицы заданы успешно");
        }
        internal static void Greуting()
        {
            Console.WriteLine("Вас приветствует программа работы с колекцией мотоциклов");

        }
        internal static void WriteInputNumberMainMenu()
        {
            Console.WriteLine("1 - Просмотреть колекцию");
            Console.WriteLine("2 - Вывести элемент колекции по ID номеру");
            Console.WriteLine("3 - Создать новый элемент колекции");
            Console.WriteLine("4 - Изменить элемент колекцию");
            Console.WriteLine("5 - Удалить элемент колекции");
        }
        internal static void WriteInputNumberUpdateMenu(out int fixTop)
        {
            Console.WriteLine("1 - Изменить имя мотоцикла");
            Console.WriteLine("2 - Изменить модель");
            Console.WriteLine("3 - Изменить год выпуска");
            Console.WriteLine("4 - Изменить пробег");
            fixTop = 7;
        }
        internal static void WriteInputNumberDeleteMenu()
        {
            Console.WriteLine("1 - да");
            Console.WriteLine("2 - нет");
        }
        internal static void WriteAllMotorcycles(Motorcycle[] motorcycles)
        {
            WriteTopTable();
            for (int i = 0; i < motorcycles.Length && motorcycles[i].Id != 0;i++) 
            {
                WriteOneMotorcycle(motorcycles[i]);
            }
        }
        internal static void WriteMotorcycle(Motorcycle motorcycle)
        {
            WriteTopTable();
            WriteOneMotorcycle(motorcycle);
        }
        internal static void WriteCreateMotorcycle(out Motorcycle motorcycle)
        {
            motorcycle = new Motorcycle();
            WriteTopTable();
            WriteColumn();
            Console.SetCursorPosition(CurcorName, Console.CursorTop);
            motorcycle.Name = MotorcycleConsoleInput.InputConsoleName(WidthName);
            Console.SetCursorPosition(CurcorModel, Console.CursorTop);
            motorcycle.Model = MotorcycleConsoleInput.InputConsoleModel(WidthModel);
            Console.SetCursorPosition(CurcorYear, Console.CursorTop);
            motorcycle.Year = MotorcycleConsoleInput.InputConsoleYear(0,DateTime.Now.Year, WidthYear);
            Console.SetCursorPosition(CurcorOdometer, Console.CursorTop);
            motorcycle.Odometer = MotorcycleConsoleInput.InputConsoleOdometer(0, (int)Math.Pow(10, WidthOdometer)-1, WidthOdometer);
            Console.WriteLine();
            Console.WriteLine("Экземпляр успешно создан     ");
        }
        internal static void WriteUpdateMotorcycle(Motorcycle motorcycle, out Motorcycle motorcycleOut)
        {

            WriteTopTable();
            WriteOneMotorcycle(motorcycle);
            Console.WriteLine();
            WriteInputNumberUpdateMenu(out int fixTop);
            switch (MotorcycleConsoleInput.InputConsoleNumber(1,4))
            {
                case 1:
                    {
                        log.Info("Update instance: >>> " + nameof(motorcycle.Name)+"-" +motorcycle.Name );
                        Console.SetCursorPosition(CurcorName, Console.CursorTop- fixTop);
                        Console.Write(new string(' ', WidthName));
                        Console.SetCursorPosition(CurcorName, Console.CursorTop);
                        motorcycle.Name = MotorcycleConsoleInput.InputConsoleName(WidthName);
                        Console.SetCursorPosition(0, Console.CursorTop + fixTop);
                        log.Info("Update instance: " + nameof(motorcycle.Name) + "-" + motorcycle.Name + " <<<");
                        break;
                    }
                case 2:
                    {
                        log.Info("Update instance: >>> " + nameof(motorcycle.Model) + "-" + motorcycle.Model);
                        Console.SetCursorPosition(CurcorModel, Console.CursorTop - fixTop);
                        Console.Write(new string(' ', WidthModel));
                        Console.SetCursorPosition(CurcorModel, Console.CursorTop);
                        motorcycle.Model = MotorcycleConsoleInput.InputConsoleModel(WidthModel);
                        Console.SetCursorPosition(0, Console.CursorTop + fixTop);
                        log.Info("Update instance: " + nameof(motorcycle.Model) + "-" + motorcycle.Model + " <<<");
                        break;
                    }
                case 3:
                    {
                        log.Info("Update instance: >>> " + nameof(motorcycle.Year) + "-" + motorcycle.Year.ToString());
                        Console.SetCursorPosition(CurcorYear, Console.CursorTop - fixTop);
                        Console.Write(new string(' ', WidthYear));
                        Console.SetCursorPosition(CurcorYear, Console.CursorTop);
                        motorcycle.Year = MotorcycleConsoleInput.InputConsoleYear(0, DateTime.Now.Year, WidthYear);
                        Console.SetCursorPosition(0, Console.CursorTop + fixTop);
                        log.Info("Update instance: " + nameof(motorcycle.Year) + "-" + motorcycle.Year.ToString() + " <<<");
                        break;
                    }
                case 4:
                    {
                        log.Info("Update instance: >>> " + nameof(motorcycle.Odometer) + "-" + motorcycle.Odometer.ToString());
                        Console.SetCursorPosition(CurcorOdometer, Console.CursorTop - fixTop);
                        Console.Write(new string(' ', WidthOdometer));
                        Console.SetCursorPosition(CurcorOdometer, Console.CursorTop);
                        motorcycle.Odometer = MotorcycleConsoleInput.InputConsoleOdometer(0, (int)Math.Pow(10, WidthOdometer) - 1, WidthOdometer);
                        Console.SetCursorPosition(0, Console.CursorTop + fixTop);
                        log.Info("Update instance: " + nameof(motorcycle.Odometer) + "-" + motorcycle.Odometer.ToString() + " <<<");
                        break;
                    }
            }
            motorcycleOut = motorcycle;
        }
        internal static bool WriteDeleteMotorcycle(Motorcycle motorcycle, out int motorcycleId)
        {
            WriteTopTable();
            WriteOneMotorcycle(motorcycle);
            Console.WriteLine("Удалить выбранный экземпляр колекции?");
            WriteInputNumberDeleteMenu();
            if (MotorcycleConsoleInput.InputConsoleNumber(1, 2) == 1)
            {
                motorcycleId = motorcycle.Id;
                return true;
            }
            else
            {
                motorcycleId = motorcycle.Id;
                return false;
            }
        }
        static void WriteTopTable()
        {
            Console.WriteLine(new string('_',WidthTable));
            WriteColumn();
            WriteLineStringColumn("ID", "Имя", "Модель", "Год", "Пробег");
            Console.WriteLine(new string('-', WidthTable));
        }
        static void WriteOneMotorcycle(Motorcycle motorcycle)
        {
            WriteColumn();
            WriteLineStringColumn(motorcycle.Id.ToString(), motorcycle.Name, motorcycle.Model, motorcycle.Year.ToString(), motorcycle.Odometer.ToString());
        }
        static void WriteColumn()
        {
            Console.Write('|');
            Console.Write(new string(' ', WidthId));
            Console.Write('|');
            Console.Write(new string(' ', WidthName));
            Console.Write('|');
            Console.Write(new string(' ', WidthModel));
            Console.Write('|');
            Console.Write(new string(' ', WidthYear));
            Console.Write('|');
            Console.Write(new string(' ', WidthOdometer));
            Console.Write('|');
        }
        static void WriteLineStringColumn(string Id, string name, string model, string year, string odometer)
        {
            Console.SetCursorPosition(CurcorId, Console.CursorTop);
            Console.Write(Id);
            Console.SetCursorPosition(CurcorName, Console.CursorTop);
            Console.Write(name);
            Console.SetCursorPosition(CurcorModel, Console.CursorTop);
            Console.Write(model);
            Console.SetCursorPosition(CurcorYear, Console.CursorTop);
            Console.Write(year);
            Console.SetCursorPosition(CurcorOdometer, Console.CursorTop);
            Console.WriteLine(odometer);
        }
        

    }
}
