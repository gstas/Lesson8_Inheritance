using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Airplane a = new Airplane();
            a.getInfo();
            a.Move();
            Console.WriteLine();

            Ship s = new Ship();
            a.getInfo();
            s.Move();
            Console.WriteLine();
            
        }
    }
}
