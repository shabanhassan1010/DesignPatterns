using System;

namespace SOLID.SOLID_Implement_2._2_2_OCP
{
    #region Bad Code
    public abstract class Shape
    {
        public abstract double Area(); 
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class Square : Shape
    {
        public double SideLength { get; set; }
        public override double Area()
        {
            return SideLength * SideLength;
        }
    }

    #endregion
}
