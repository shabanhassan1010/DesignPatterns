using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuliderDP.ComputerExample.ComputerIngrdients
{
    public class Keyboard
    {
        private bool utfSupport;

        public Keyboard(bool utfSupport)
        {
            this.utfSupport = utfSupport;
        }

        public bool IsUtfSupport()
        {
            return utfSupport;
        }
    }
}
