using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuliderDP.ComputerExample.ComputerIngrdients.MotherB.MainParts
{
    public class NetworkCard
    {
        private int category;

        public NetworkCard(int category)
        {
            this.category = category;
        }

        public int GetCategory()
        {
            return category;
        }
    }

}
