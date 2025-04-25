using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple.OpenClose
{
    public class AreaCalculator2  // Applies OCP
    {
        public double CalculateArea(IShape shape)
        {
            return shape.GetArea();
        }
    }
}
