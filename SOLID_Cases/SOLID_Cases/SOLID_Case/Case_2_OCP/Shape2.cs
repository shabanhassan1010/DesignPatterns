using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SOLID_Case_Answer.Case_Answer_2_OCP
{
    #region Bad Code
    public abstract class Shape
    {
        public abstract double Area { get; }
    }

    public class Rectangle : Shape
    {
        private double Width { get; }
        private double Height { get; }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public override double Area => Width * Height;
    }

    public class Circle : Shape
    {
        private double Radius { get; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double Area => Math.PI * Radius * Radius;
    }

    #endregion
}
