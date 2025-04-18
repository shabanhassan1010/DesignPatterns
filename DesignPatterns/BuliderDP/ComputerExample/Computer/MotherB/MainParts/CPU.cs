using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuliderDP.ComputerExample.ComputerIngrdients.MotherB.MainParts
{
    public class CPU
    {
        private float speed;

        public CPU(float speed)
        {
            this.speed = speed;
        }

        public float GetSpeed()
        {
            return speed;
        }
    }
}
