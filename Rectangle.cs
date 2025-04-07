using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetPractice
{
    public class Rectangle:Shape
    {
        private double _length;
        private double _width;
        public double Length { get { return _length; } set {  _length = value; } }
        public double Width { get { return _width; } set { _width = value; } }

        public Rectangle()
        {
            
        }

        public Rectangle(double length, double width)
        {
            _length = length;
            _width = width;
        }

        public double CalculateArea(double length, double width)
        {
            _length = length;
            _width = width;
            Area = length * width;
            return Area;
        }

        public double CalculateArea()
        {
            Area = Length * Width;
            return Area;
        }

    }
}
