using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuliderDP.ComputerExample.ComputerIngrdients.MotherB.MainParts
{
    public class RAM
    {
        private int size;

        public RAM(int size)
        {
            this.size = size;
        }

        // Note: Same naming inconsistency as GPU class
        public int GetSpeed()
        {
            return size;
        }
    }
}
