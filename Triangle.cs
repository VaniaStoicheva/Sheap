using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Principles_Part_2
{
    class Triangle:Shape
    {
        public Triangle(double width, double height)
            : base(width, height)
        {
        }

        public override double CalculateSurface()
        {
            double surface=(double)(this.Height *this.Width )/ 2;
            return  surface;
        }

    }
}
