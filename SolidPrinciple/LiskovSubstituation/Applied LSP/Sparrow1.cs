using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple.LiskovSubstituation.Applied_LSP
{
    public class Sparrow1 : IFlyingBird
    {
        public void Eat()
        {
            Console.WriteLine("Sparrow eating...");
        }
        public void Fly() 
        {
            Console.WriteLine("Sparrow flying...");
        } 
    }
}
