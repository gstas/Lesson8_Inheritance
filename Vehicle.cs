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

        public virtual string Name { get => name; set => name = value; }
        public virtual string Color { get => color; set => color = value; }

        public void getInfo() {
            Console.WriteLine("Что: {0}, Цвет: {1}", Name, Color);
        }


        public virtual void Move() {
            Console.WriteLine("{0} {1} как-то двигается...", Color, Name);
        }
    }
}
