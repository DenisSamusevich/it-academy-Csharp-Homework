using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW13.Task1
{
    class Motorcycle
    {
        internal int Id { get; set; } = 0;
        internal string Name { get; set; } = string.Empty;
        internal string Model { get; set; } = string.Empty;
        internal int Year { get; set; } = 0;
        internal int Odometer { get; set; } = 0;
        internal Motorcycle()
        {
        }
        internal Motorcycle(int id)
        {
            Random random = new Random();
            switch (id)
            {
                case 1:
                    {
                        Id = id;
                        Name = "Ducati";
                        Model = "Diavel";
                        Year = random.Next(1995,2019);
                        Odometer = random.Next(20, 301);
                        break;
                    }
                case 2:
                    {
                        Id = id;
                        Name = "BMW";
                        Model = "HP4 Race";
                        Year = random.Next(1996, 2019);
                        Odometer = random.Next(20, 302);
                        break;
                    }
                case 3:
                    {
                        Id = id;
                        Name = "Honda";
                        Model = "Fireblade";
                        Year = random.Next(1997, 2019);
                        Odometer = random.Next(20, 303);
                        break;
                    }
                case 4:
                    {
                        Id = id;
                        Name = "Kawasaki";
                        Model = "Ninja H2R";
                        Year = random.Next(1998, 2019);
                        Odometer = random.Next(20, 304);
                        break;
                    }
                case 5:
                    {
                        Id = id;
                        Name = "Yamaha";
                        Model = "YZF-R1";
                        Year = random.Next(1999, 2019);
                        Odometer = random.Next(20, 305);
                        break;
                    }
                case 6:
                    {
                        Id = id;
                        Name = "KTM";
                        Model = "Duke GT";
                        Year = random.Next(2000, 2019);
                        Odometer = random.Next(20, 300);
                        break;
                    }
                default:
                    {
                        break;
                    }


            }
        }

    }
}
