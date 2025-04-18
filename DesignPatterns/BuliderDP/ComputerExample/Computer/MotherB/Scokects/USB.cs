using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuliderDP.ComputerExample.ComputerIngrdients.MotherB.Scokects
{
    public class USB
    {
        private string version;

        public USB(string version)
        {
            this.version = version;
        }

        // Renamed to avoid conflict with Object.GetType()
        public string GetVersion()
        {
            return version;
        }
    }
}
