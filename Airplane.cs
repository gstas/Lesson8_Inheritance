using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Inheritance
{
    class Airplane : Vehicle
    {
        string name = "Самолёт";
        string color = "Красный";
        byte wingSpan = 50; // размах крыльев

        public override void Move()
        {
            Console.WriteLine("{0} {1} летит!", color, name);
        }
    }
}
