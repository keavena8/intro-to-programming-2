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
            Console.WriteLine(comp1.Format());
            Console.ReadLine();
        }
    }
}
