using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Association
{
    public abstract class Teacher
    {
        public string Name { get; }
        protected Teacher(string name)
        {
            Name = name;
        }
        public abstract string AssignQuestion();
        public string EvaluateStudentHomeWork(Student student)
        {
            return student.HomeWorkScore >= 50 ? "Success" : "Failed";
        }
    }
}
