using DesignPatterns.BuliderDP.ComputerExample.ComputerIngrdients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuliderDP.ComputerExample.ComputerIngrdients.Types
{
    public class ComputerCS : Computer, ICoolingSystem
    {
        private CoolingSystem cs;

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

        public void SetCs(CoolingSystem cs)
        {
            this.cs = cs;
        }

        public CoolingSystem GetCs()
        {
            return cs;
        }

        public bool coolDown(int temp)
        {
            throw new NotImplementedException();
        }
    }
}
