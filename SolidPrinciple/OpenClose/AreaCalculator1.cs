using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple.OpenClose
{
    public class AreaCalculator1 // violates OCP
    {
        public double CalculateArea(object shape)
        {
            if (shape is Circle circle)
            {
                return Math.PI * circle.Radius * circle.Radius;
            }
            else if (shape is Rectangle rect)
            {
                return rect.Width * rect.Height;
            }
            // And If Any New Requirements appear must open this function
            // in this class and added in it the new Requirements..
            return 0;
        }
    }
}
