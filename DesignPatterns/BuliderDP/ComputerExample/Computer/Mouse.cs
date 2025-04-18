using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuliderDP.ComputerExample.ComputerIngrdients
{
    public class Mouse
    {
        private bool withExtraUtilities;

        public Mouse(bool withExtraUtilities)
        {
            this.withExtraUtilities = withExtraUtilities;
        }

        public bool IsUtfSupport()
        {
            return withExtraUtilities;
        }
    }
}
