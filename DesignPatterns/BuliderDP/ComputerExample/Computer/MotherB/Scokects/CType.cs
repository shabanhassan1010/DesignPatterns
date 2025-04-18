using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuliderDP.ComputerExample.ComputerIngrdients.MotherB.Scokects
{
    public class CType
    {
        private bool withVideoTransfer;

        public CType(bool withVideoTransfer)
        {
            this.withVideoTransfer = withVideoTransfer;
        }

        public bool IsWithVideoTransfer()
        {
            return withVideoTransfer;
        }
    }
}
