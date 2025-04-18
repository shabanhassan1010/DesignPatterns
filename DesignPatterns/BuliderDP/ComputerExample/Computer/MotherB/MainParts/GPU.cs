using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuliderDP.ComputerExample.ComputerIngrdients.MotherB.MainParts
{
    public class GPU
    {
        private int size;

        public GPU(int size)
        {
            this.size = size;
        }

        // Note: Method name seems mismatched with returned property (size vs speed)
        public int GetSpeed()
        {
            return size;
        }
    }
}
