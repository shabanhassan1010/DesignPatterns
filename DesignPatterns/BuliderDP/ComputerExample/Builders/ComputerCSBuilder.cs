using DesignPatterns.BuliderDP.ComputerExample.ComputerIngrdients.MotherB.MainParts;
using DesignPatterns.BuliderDP.ComputerExample.ComputerIngrdients.MotherB.Scokects;
using DesignPatterns.BuliderDP.ComputerExample.ComputerIngrdients.MotherB;
using DesignPatterns.BuliderDP.ComputerExample.ComputerIngrdients.Types;
using DesignPatterns.BuliderDP.ComputerExample.ComputerIngrdients;

namespace DesignPatterns.BuliderDP.ComputerExample.Builders
{
    public class ComputerCSBuilder : Builder
    {
        protected override MotherBoard BuildMotherBoard()
        {
            // Note: Changed USB parameters to strings to match class definition
            var cpu = new CPU(2.8f);
            var ram = new RAM(16);
            var gpu = new GPU(2);
            var sockets = new Sockets(new object[] {
            new USB("2.0"),    // Updated to string
            new USB("3.0"),     // Updated to string
            new CType(true),
            new CType(true),
            new CType(true)
        });
            var networkCard = new NetworkCard(5);
            var disk = new Disk("SSD");

            return new MotherBoard(cpu, ram, gpu, sockets, networkCard, disk);
        }

        protected override Keyboard BuildKeyboard() => new Keyboard(true);
        protected override Mouse BuildMouse() => new Mouse(false);
        //protected override Monitor BuildMonitor() => new Monitor("1920 FHD");
        protected override CoolingSystem BuildCollingSystem() => new CoolingSystem(5);
        protected override UPS BuildUPS() => new UPS(96);

        public override Computer GetComputer()
        {
            var computer = new ComputerCS();
            computer.SetKeyboard(BuildKeyboard());
            //computer.SetMonitor(BuildMonitor());
            computer.SetMotherBoard(BuildMotherBoard());
            computer.SetCs(BuildCollingSystem());
            return computer;
        }
    }
}
