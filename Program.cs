using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)

        {
            employee myEmployee = new employee("Pat", "male", 10, "American");
            Console.WriteLine(myEmployee.ToString());
            Console.ReadLine();
        }
    }
}
