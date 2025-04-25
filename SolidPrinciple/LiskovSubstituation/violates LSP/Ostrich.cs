using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple.LiskovSubstituation
{
    public class Ostrich : Bird
    {
        public override void Fly()
        {
            throw new NotImplementedException(); // Ostrich can't fly ❌
        }
    }
}
