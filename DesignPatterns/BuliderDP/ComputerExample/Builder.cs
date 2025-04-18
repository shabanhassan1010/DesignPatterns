using DesignPatterns.BuliderDP.ComputerExample.ComputerIngrdients.MotherB;
using DesignPatterns.BuliderDP.ComputerExample.ComputerIngrdients;
using DesignPatterns.BuliderDP.ComputerExample.ComputerIngrdients.Types;

namespace DesignPatterns.BuliderDP.ComputerExample
{
    public abstract class Builder
    {
        protected abstract MotherBoard BuildMotherBoard();
        protected abstract Keyboard BuildKeyboard();
        protected abstract Mouse BuildMouse();
        //protected abstract Monitor BuildMonitor();
        protected abstract CoolingSystem BuildCollingSystem();  // Note: Typo preserved from original
        protected abstract UPS BuildUPS();
        public abstract Computer GetComputer();
    }
}
