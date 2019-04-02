using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_10_q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car MyCar = new Car("Audi", "Red", 981);
            Car MyCar2 = new Car("Ford", "Blue", 8821);
            Car MyCar3 = new Car("BMW", "Green", 1);
            Console.WriteLine(MyCar.ToString());
            Console.WriteLine(MyCar2.ToString());
            Console.WriteLine(MyCar3.ToString());
            Console.ReadLine();

        }
    }
}
