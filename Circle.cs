using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Principles_Part_2
{
    class Circle:Shape
    {
        public Circle(double width, double height)
            : base(width, height)
        {
            if (!this.Width.Equals(Height))
            {
                throw new ArgumentException("The height must be equals to width ");
            }
            this.Width = height;
        }
        public override void PrintInfo()
        {
            Console.WriteLine("{0} surface {1:F4}", this.GetType().Name, this.CalculateSurface());
        }
        public override double CalculateSurface()
        {
            return Height * Height * Math.PI;
        }
    }

}
