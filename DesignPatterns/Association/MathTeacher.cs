using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Association
{
    public class MathTeacher : Teacher
    {
        public MathTeacher(string name) : base(name)
        {
        }
        public override string AssignQuestion()
        {
            return "Calculate the sum of 10 and 12";
        }
    }
}
