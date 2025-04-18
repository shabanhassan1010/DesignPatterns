using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuliderDP.ComputerExample.ComputerIngrdients
{
    public class UPS
    {
        private int duration;

        public UPS(int duration)
        {
            this.duration = duration;
        }

        public int IsUtfSupport()
        {
            return duration;
        }
    }
}
