using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_10_q1
{
    class Circle
    {
        private int _radius;
        private int _x = 1;
        private int _y;

        public int Radius
        {
            get
            {
                return _radius;

            }
            set
            {
                _radius = value;
            }
        }
        public int x
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }
        public int y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }
        public Circle(int r, int x, int y)
        {

            _radius = r;
            _x = x;
            _y = y;
        }
        public double GetArea()
        {
            return Radius * Radius * Math.PI;
        }
        public override string ToString()
        {
            return "The radius of the circle is " + Radius;
        }
    }
}
