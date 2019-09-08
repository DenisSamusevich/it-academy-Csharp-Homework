using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;

namespace HW13.Task1
{
    class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));
        static void Main(string[] args)
        {
            string baseDirectory = Path.GetDirectoryName(Path.GetDirectoryName(Environment.CurrentDirectory));
            GlobalContext.Properties["LogFileName"] = baseDirectory;
            XmlConfigurator.Configure();
            log.Info("Entering application.");
            MotorcycleRepository motorcycleRepository = new MotorcycleRepository();
            MotorcycleConsoleWrite.Greуting();
            start:
            MotorcycleConsoleWrite.WriteInputNumberMainMenu();
            switch (MotorcycleConsoleInput.InputConsoleNumber(1, 5))
            {
                case 1:
                    {
                        MotorcycleConsoleWrite.WriteAllMotorcycles(motorcycleRepository.GetMotorcycles());
                        goto start;
                    }
                case 2:
                    {
                        MotorcycleConsoleWrite.WriteMotorcycle(motorcycleRepository.GetMotorcycleByID(MotorcycleConsoleInput.InputConsoleNumberId(MotorcycleDataBase.MinNumberCollection, MotorcycleDataBase.СurrentNumberCollection)));
                        goto start;
                    }
                case 3:
                    {
                        MotorcycleConsoleWrite.WriteCreateMotorcycle(out Motorcycle motorcycleCreate);
                        motorcycleRepository.CreateMotorcycle(motorcycleCreate);
                        goto start;
                    }
                case 4:
                    {
                        MotorcycleConsoleWrite.WriteUpdateMotorcycle(motorcycleRepository.GetMotorcycleByID(MotorcycleConsoleInput.InputConsoleNumberIdUpdate(MotorcycleDataBase.MinNumberCollection, MotorcycleDataBase.СurrentNumberCollection)), out Motorcycle motorcycleUpdate);
                        motorcycleRepository.UpdateMotorcycle(motorcycleUpdate);
                        goto start;
                    }
                case 5:
                    {
                        if (MotorcycleConsoleWrite.WriteDeleteMotorcycle(motorcycleRepository.GetMotorcycleByID(MotorcycleConsoleInput.InputConsoleNumberIdDelete(MotorcycleDataBase.MinNumberCollection, MotorcycleDataBase.СurrentNumberCollection)),out int inputId))
                        {
                            motorcycleRepository.DeleteMotorcycle(inputId);
                            goto start;
                        }
                        else
                        {
                            goto start;
                        }
                    }
                default:
                    goto start;
            }
            
        }
    }
}
