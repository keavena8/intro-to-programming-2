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
            Laptop lap1 = new Laptop("Dell", "USA", "Inspiron", "Blue");
            Desktop desk1 = new Desktop("Dell", "USA", "XPS", "Red");
            Console.WriteLine(comp1.Format());
            Console.WriteLine(lap1.FormatLaptop());
            Console.WriteLine(desk1.FormatDesk());
            Console.ReadLine();
        }
    }
}
