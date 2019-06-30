using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Inheritance
{
    class Ship : Vehicle
    {
        string name = "Корабль";
        string color = "Белый";
        ushort displacement = 7500; // Водоизмещение

        public override void Move()
        {
            Console.WriteLine("{0} {1} плывет!", color, name);
        }
    }
}
