using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Association
{
    public class ScienceTeacher : Teacher
    {
        public ScienceTeacher(string name) : base(name)
        {
        }

        public override string AssignQuestion()
        {
            return "Prepare a research on plants";
        }
    }
}
