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
            Car MyCar = new Car("Audi", "Blue", 8821);
            Console.WriteLine(MyCar.ToString());
            Console.ReadLine();
             
        }
    }
}
