using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple.LiskovSubstituation.Applied_LSP
{
    public class Ostrich1 : IBird
    {
        public void Eat()
        {
            Console.WriteLine("Ostrich eating...");
        }
    }
}
