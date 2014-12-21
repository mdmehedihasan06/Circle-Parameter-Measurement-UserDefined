using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleMeasurementApp
{
    class Circle
    {
        public double radious;
        public double diameter;
        public double perimeter;
        public double area;
        //public double pi;

        public double GetDiameter()
        {
            return 2*radious;
        }

        public double GetPerimeter()
        {
            return 2*Math.PI*radious;
        }

        public double GetArea()
        {
            return Math.Pow(radious, 2)*Math.PI;
        }
    }
}
