using DesignPatterns.FactoryMethod_DP.Buttons;

namespace DesignPatterns.FactoryMethod_DP.Dialog
{
    internal class MobileDialog : Dialog
    {
        public override Button CreatedButton()
        {
            return new MobileButton();
        }
    }
}