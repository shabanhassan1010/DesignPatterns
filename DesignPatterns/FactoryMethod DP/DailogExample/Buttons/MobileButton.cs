
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
