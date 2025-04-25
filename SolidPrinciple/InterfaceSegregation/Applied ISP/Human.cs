using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple.InterfaceSegregation
{
    public class Human : IWorkable, IEatable
    {
        public void Work() => Console.WriteLine("Human is working...");
        public void Eat() => Console.WriteLine("Human is eating...");
    }
}
