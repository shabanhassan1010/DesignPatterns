using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuliderDP.ComputerExample.ComputerIngrdients.MotherB.MainParts
{
    public class Sockets
    {
        private object[] sockets;  // Using object[] for generic array

        public Sockets(object[] sockets)
        {
            this.sockets = sockets;
        }

        public object[] GetSockets()
        {
            return sockets;
        }
    }
}
