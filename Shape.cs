using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetPractice
{
    public class Shape
    {
        protected double Area {  get; set; }

        public Shape()
        {
            Area = 0;
        }
        
        public double CalculateArea() 
        { 
            return Area;
        }
    }
}
