using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuliderDP.ComputerExample.ComputerIngrdients
{
    public class CoolingSystem
    {
        private int lowTempLimit;

        public CoolingSystem(int lowTempLimit)
        {
            this.lowTempLimit = lowTempLimit;
        }

        public int IsUtfSupport()
        {
            return lowTempLimit;
        }
    }
}
