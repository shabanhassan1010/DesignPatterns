using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple.LiskovSubstituation
{
    public class Sparrow : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Sparrow flying...");
        }
    }
}
