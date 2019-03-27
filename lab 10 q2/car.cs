using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_10_q2
{
    class Car
    {
        private string _brand;
        private string _colour;
        private int _regNumber;

        public string Brand
        {
           get
           {
                return _brand;
           }
           set
           {
                _brand = value;
           }
        }
        public string Colour
        {
            get
            {
                return _colour;
            }
            set
            {
                _colour = value;
            }
        }
        public int RegNumber
        {
            get
            {
                return _regNumber;
            }
            set
            {
                _regNumber = value;
            }
        }
        public Car(string b, string c, int r)
        {
            _brand = b;
            _colour = c;
            _regNumber = r;

            if (b == "Audi" || b == "BMW" || b == "VW")
            {
                Console.WriteLine("This is the correct car!");
            }
            else
            {
                Console.WriteLine("This car is incorrect! It can only be Audi, VW and BMW");
            }
        }
        public override string ToString()
        {
            return "Car: " + Brand + "\nColour: " + Colour + "\nRegistration Number: " + RegNumber;
        }

    }
}
