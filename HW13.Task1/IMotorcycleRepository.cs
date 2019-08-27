using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW13.Task1
{
    internal interface IMotorcycleRepository
    {
        Motorcycle[] GetMotorcycles();
        Motorcycle GetMotorcycleByID(int motorcycleId);
        void CreateMotorcycle(Motorcycle motorcycle);
        void UpdateMotorcycle(Motorcycle motorcycle);
        void DeleteMotorcycle(int motorcycleId);
    }
}
