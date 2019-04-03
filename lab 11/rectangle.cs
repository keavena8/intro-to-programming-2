using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class rectangle
    {
        private int _length;
        private int _width;
        public int Length
        {
            get
            {
                return _length;
            }
            set
            {
                _length = value;
            }
        }
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        }
        public  rectangle(int l, int w)
        {
            _length = l;
            _width = w;
        }
        public virtual int calcArea()
        {
            return Length * Width;
        }
        public  override string ToString()
        {
            return "Length" + Length.ToString() + "Width" + Width.ToString();
        }

    }
    class Box : rectangle
    {
        private int _depth;
        public int Depth
        {
            get
            {
                return _depth;
            }
            set
            {
                _depth = value;
            }
        }
        public Box(int l, int w, int h) : base(l, w)
        {
            _depth = h;
        }
        public override int calcArea()
        {
            return 2 * (Length * Width) + 2 * (Width * Depth) + 2 * (Length * Depth);
        }
        public int calcVolume()
        {
            return (4 * Length) + (3 * Width) + (2 * Depth);
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
