using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetPractice
{
    public class Circle:Shape
    {
        private double _radius;
        public double Radius { get { return _radius; } set {  _radius = value; } }

        public Circle()
        {
            
        }

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double CalculateArea(double radius) 
        { 
            _radius = radius;
            Area = Math.PI * radius * radius;
            return Area;
        }

        public double CalculateArea()
        {
            Area = Math.PI * Radius * Radius;
            return Area;
        }
    }
}
