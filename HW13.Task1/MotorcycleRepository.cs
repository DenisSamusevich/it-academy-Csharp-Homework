using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace HW13.Task1
{
    class MotorcycleRepository
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(MotorcycleRepository));
        public static Motorcycle[] GetMotorcycles()
        {
            log.Info("All instances received");
            return MotorcycleDataBase.Motorcycles;
        }
        public static Motorcycle GetMotorcycleByID(int motorcycleId)
        {
            log.Info(motorcycleId.ToString()+" instance received");
            return MotorcycleDataBase.Find(motorcycleId);
        }
        public static void CreateMotorcycle(Motorcycle motorcycle)
        {
            log.Info("Instance created:" + nameof(motorcycle.Name) + "-"+ motorcycle.Name+ ", "+nameof(motorcycle.Model) + "-" + motorcycle.Model+", "+nameof(motorcycle.Year) + "-" + motorcycle.Year.ToString()+ ", " + nameof(motorcycle.Odometer) + "-" + motorcycle.Odometer.ToString());
            MotorcycleDataBase.Insert(motorcycle);
        }
        public static void UpdateMotorcycle(Motorcycle motorcycle)
        {
            log.Info(motorcycle.Id.ToString() + " instance updated");
            MotorcycleDataBase.Update(motorcycle);
        }
        public static void DeleteMotorcycle(int motorcycleId)
        {
            log.Info(motorcycleId.ToString() + " instance deleted");
            MotorcycleDataBase.Delete(motorcycleId);
        }
    }
}
