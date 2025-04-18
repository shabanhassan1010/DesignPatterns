using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuliderDP.ComputerExample.ComputerIngrdients.MotherB.MainParts
{
    public class Disk
    {
        private string type;

        public Disk(string type)
        {
            this.type = type;
        }

        // Note: Renamed to avoid conflict with Object.GetType()
        public string GetDiskType()
        {
            return type;
        }
    }
}
