using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple.InterfaceSegregation
{
    public class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot is working...");
        }

        public void Eat()
        {
            // Robot doesn't eat, but forced to implement
            throw new NotImplementedException();
        }
    }
}
