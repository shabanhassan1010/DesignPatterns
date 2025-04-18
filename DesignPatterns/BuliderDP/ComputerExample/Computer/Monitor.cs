using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuliderDP.ComputerExample.ComputerIngrdients
{
    public class Monitor
    {
        private string resolution;

        public Monitor(string resolution)
        {
            this.resolution = resolution;
        }

        public string GetResolution()
        {
            return resolution;
        }
    }
}
