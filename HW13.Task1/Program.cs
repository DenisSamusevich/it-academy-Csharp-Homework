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
            MotorcycleConsoleWrite.Greуting();
            start:
            MotorcycleConsoleWrite.WriteInputNumberMainMenu();
            switch (MotorcycleConsoleInput.InputConsoleNumber(1, 5))
            {
                case 1:
                    {
                        MotorcycleConsoleWrite.WriteAllMotorcycles(MotorcycleRepository.GetMotorcycles());
                        goto start;
                    }
                case 2:
                    {
                        MotorcycleConsoleWrite.WriteMotorcycle(MotorcycleRepository.GetMotorcycleByID(MotorcycleConsoleInput.InputConsoleNumberId(MotorcycleDataBase.MinNumberCollection, MotorcycleDataBase.СurrentNumberCollection)));
                        goto start;
                    }
                case 3:
                    {
                        MotorcycleConsoleWrite.WriteCreateMotorcycle(out Motorcycle motorcycleCreate);
                        MotorcycleRepository.CreateMotorcycle(motorcycleCreate);
                        goto start;
                    }
                case 4:
                    {
                        MotorcycleConsoleWrite.WriteUpdateMotorcycle(MotorcycleRepository.GetMotorcycleByID(MotorcycleConsoleInput.InputConsoleNumberIdUpdate(MotorcycleDataBase.MinNumberCollection, MotorcycleDataBase.СurrentNumberCollection)), out Motorcycle motorcycleUpdate);
                        MotorcycleRepository.UpdateMotorcycle(motorcycleUpdate);
                        goto start;
                    }
                case 5:
                    {
                        if (MotorcycleConsoleWrite.WriteDeleteMotorcycle(MotorcycleRepository.GetMotorcycleByID(MotorcycleConsoleInput.InputConsoleNumberIdDelete(MotorcycleDataBase.MinNumberCollection, MotorcycleDataBase.СurrentNumberCollection)),out int inputId))
                        {
                            MotorcycleRepository.DeleteMotorcycle(inputId);
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
