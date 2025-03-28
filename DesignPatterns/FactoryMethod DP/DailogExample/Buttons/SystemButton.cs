using DesignPatterns.FactoryMethod_DP.Buttons;

namespace DesignPatterns.FactoryMethod_DP.Dialog
{
    internal class SystemButton : Button
    {
        public override void Click()
        {
            Console.WriteLine("Click From SystemButton ");
        }

        public override string Show()
        {
            return "System Button Show";
        }
    }
}