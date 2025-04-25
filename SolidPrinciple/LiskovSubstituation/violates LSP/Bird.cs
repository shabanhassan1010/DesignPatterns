namespace SolidPrinciple.LiskovSubstituation
{
    public class Bird
    {
        public virtual void Fly()
        {
            Console.WriteLine("This bird can fly.");
        }
    }
}