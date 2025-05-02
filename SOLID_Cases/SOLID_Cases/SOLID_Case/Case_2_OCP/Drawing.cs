using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SOLID_Case_Answer.Case_Answer_2_OCP
{
    #region Bad Code
    public class Drawing
    {
        public string DrawShape(IShape shape)
        {
            return shape.Draw();
        }
    }
    public interface IShape
    {
        string Draw();
    }
    class Circle1 : IShape
    {
        public string Draw()
        {
            return "Drawing a Circle";
        }
    }
    class Square : IShape
    {
        public string Draw()
        {
            return "Drawing a Square";
        }
    }
    #endregion
}
