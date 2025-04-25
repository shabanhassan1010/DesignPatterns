using SolidPrinciple.LiskovSubstituation.Applied_LSP;
using SolidPrinciple.LiskovSubstituation;

namespace SolidPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Using IFlyingBird
            IFlyingBird flyingBird = new Sparrow1();
            flyingBird.Eat();
            flyingBird.Fly();

            IBird FlyingBird = new Sparrow1();
            FlyingBird.Eat();

            // Using IBird
            IBird nonFlyingBird = new Ostrich1();
            nonFlyingBird.Eat();
            // nonFlyingBird.Fly(); ❌ Not allowed — LSP is preserved
        }
    }
}
