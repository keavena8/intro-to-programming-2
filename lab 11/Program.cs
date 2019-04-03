using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            rectangle newrect = new rectangle(5, 3);
            Box newbox = new Box(5, 3, 5);
            Console.WriteLine("Area of the rectangle: " + newrect.calcArea());
            Console.WriteLine("Area of the box: " + newbox.calcArea());
            Console.WriteLine("Volume of the box: " + newbox.calcVolume());
            Console.ReadLine();
        }
    }
}
