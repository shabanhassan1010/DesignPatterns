using DesignPatterns.BuliderDP.ComputerExample.ComputerIngrdients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuliderDP.ComputerExample.ComputerIngrdients.Types
{
    public class ComputerXL : Computer, ICoolingSystem, IPower
    {
        private CoolingSystem cs;
        private UPS ups;

        public override bool TurnOn()
        {
            // Implementation logic
            return true;
        }

        public override bool TurnOff()
        {
            // Implementation logic
            return true;
        }

        public bool CoolDown(int temp)
        {
            // Cooling implementation
            return true;
        }

        public bool BackupPower()
        {
            // Power backup implementation
            return true;
        }

        public void SetCs(CoolingSystem cs)
        {
            this.cs = cs;
        }

        public void SetUps(UPS ups)
        {
            this.ups = ups;
        }

        public CoolingSystem GetCs()
        {
            return cs;
        }

        public UPS GetUps()
        {
            return ups;
        }
    }
}
