using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple.InterfaceSegregation.Applied_ISP
{
    public class Robot1 : IWorkable
    {
        public void Work() => Console.WriteLine("Robot is working...");
    }
}
