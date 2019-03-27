using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_10_q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle MyCircle = new Circle(5, 1, 10);
            Console.WriteLine(MyCircle.ToString());
            Console.WriteLine(MyCircle.GetArea());
            Console.ReadLine();
        }
    }
}
