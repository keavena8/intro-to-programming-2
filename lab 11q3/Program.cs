using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            computer comp1 = new computer("Dell", "Usa");
            laptop lap1 = new laptop("Dell", "Usa", "Inspirion", "Red");
            desktop desk1 = new desktop("Dell", "USA", "FOLL", "Blue");
            Console.WriteLine(comp1.ToString());
            Console.WriteLine(lap1.ToString());
            Console.WriteLine(desk1.ToString());
            Console.ReadLine();
        }
    }
}
