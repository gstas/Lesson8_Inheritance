using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Inheritance
{
    abstract class Vehicle
    {
        string name = "Техника";
        string color = "Бесцветная";

        public virtual void Move() {
            Console.WriteLine("{0} {1} как-то двигается...", color, name);
        }
    }
}
