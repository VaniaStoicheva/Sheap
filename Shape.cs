using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Principles_Part_2
{
    abstract class Shape
    {
        private double width;
        private double height;

        public Shape(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Width
        {
            get { return this.width; }
            set { this.width = value; }
        }
        public double Height { 
            get { return this.height;}
            set { this.height = value; }
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine("{0} surface {1}",this.GetType().Name,this.CalculateSurface());
        }
        public abstract double CalculateSurface(); 
    }
}
