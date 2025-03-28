using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod_DP.Buttons
{
    public class MobileButton : Button
    {
        public override void Click()
        {
            Console.WriteLine("MobileButton click");
        }
        public override string Show()
        {
            return "Mobile Button";
        }
    }
}
