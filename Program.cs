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
            a.Move();

            Ship s = new Ship();
            s.Move();
        }
    }
}
