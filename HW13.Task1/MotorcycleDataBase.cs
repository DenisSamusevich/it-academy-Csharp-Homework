using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace HW13.Task1
{
    class MotorcycleDataBase
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(MotorcycleDataBase));
        internal static Motorcycle[] Motorcycles { get; }
        internal static int MaxNumberCollection { get; }
        internal static int MinNumberCollection { get; } = 1;
        internal static int СurrentNumberCollection { get; set; } = 0;
        static MotorcycleDataBase()
        {
            log.Info("Datebase start create.");
            Console.WriteLine("Необходимо ввести максимальное количество элементов в колекции");
            MaxNumberCollection = MotorcycleConsoleInput.InputConsoleNumber(MinNumberCollection, int.MaxValue);
            Motorcycle[] MotorcyclesCreate = new Motorcycle[MaxNumberCollection];
            for (int i = 0; i < MotorcyclesCreate.Length; i++)
            {
                MotorcyclesCreate[i] = new Motorcycle(i+1);
            }
            Motorcycles = MotorcyclesCreate;
            for (int i = 0; i < MotorcyclesCreate.Length && Motorcycles[i].Id != 0; i++)
            {
                СurrentNumberCollection=i+1;
            }
            Console.WriteLine("Создана стандартная колекция в которой "+ СurrentNumberCollection.ToString()+ " экземпляров");
        }
        internal static Motorcycle Find(int motorcycleId)
        {
            Motorcycle motorcycle = new Motorcycle();
            for (int i = 0; i< СurrentNumberCollection; i++)
            {
                if (Motorcycles[i].Id == motorcycleId)
                {
                    motorcycle = Motorcycles[i];
                    break;
                }
            }
            return motorcycle;
        }
        internal static void Insert(Motorcycle motorcycle)
        {
            if (СurrentNumberCollection < MaxNumberCollection)
            {
                Motorcycles[СurrentNumberCollection] = motorcycle;
                Motorcycles[СurrentNumberCollection].Id = СurrentNumberCollection+1;
                СurrentNumberCollection += 1;
                log.Info(СurrentNumberCollection.ToString()+" instance added");
            }
            else
            {
                log.Warn("Datebase is full, instance not added.");
                Console.WriteLine("Ошибка - колекция заполнена полностью.");
            }
        }
        internal static void Update(Motorcycle motorcycle)
        {
            for (int i = 0; i < СurrentNumberCollection; i++)
            {
                if (Motorcycles[i].Id == motorcycle.Id)
                {
                    Motorcycles[i] = motorcycle;
                    break;
                }
            }
        }
        internal static void Delete(int motorcycleId)
        {
            for (int i = 0; i < СurrentNumberCollection; i++)
            {
                if (Motorcycles[i].Id == motorcycleId)
                {
                    if(Motorcycles[i].Id== СurrentNumberCollection)
                    {
                        Motorcycles[i] = new Motorcycle();
                        СurrentNumberCollection -= 1;
                        break;
                    }
                    Motorcycles[i] = Motorcycles[i + 1];
                    Motorcycles[i + 1] = new Motorcycle();
                    Motorcycles[i].Id = i + 1;
                    motorcycleId += 1;
                    Motorcycles[i + 1].Id = i + 2;
                    if (i+2 == MaxNumberCollection)
                    {
                        Motorcycles[i+1] = new Motorcycle();
                        СurrentNumberCollection -= 1;
                        break;
                    }
                }
            }
        }
    }
}
