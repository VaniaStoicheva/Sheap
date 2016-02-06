using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Principles_Part_2
{
    class TestShape
    {
        public static void Main()
        {
            Shape triangle = new Triangle(2.1,3.1);
           triangle.PrintInfo();

            Shape rectangle = new Rectangle(2.1,3.1);
            rectangle.PrintInfo();

            Shape circle = new Circle(2.1,2.1);
            circle.PrintInfo();

            Shape[] shape = { triangle, rectangle, circle };
            //var sortedShape = shape.OrderBy<Shape,Shape>(Shape=>Shape.CalculateSurface()).ToList<double>;
            var sortShape =
                from surface in shape
                orderby surface.CalculateSurface()
                select surface;
            foreach (var item in sortShape)
            {
                Console.WriteLine("{0}->{1}",item.GetType().Name,item.CalculateSurface());
            }
        }
    }
}
