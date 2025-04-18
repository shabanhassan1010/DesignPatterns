using DesignPatterns.BuliderDP.ComputerExample.ComputerIngrdients;
using DesignPatterns.BuliderDP.ComputerExample.ComputerIngrdients.MotherB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuliderDP.ComputerExample.ComputerIngrdients.Types
{
    public abstract class Computer
    {
        protected MotherBoard motherBoard;
        protected Keyboard keyboard;
        protected Mouse mouse;
        protected Monitor monitor;

        public abstract bool TurnOn();
        public abstract bool TurnOff();

        public void SetMotherBoard(MotherBoard motherBoard)
        {
            this.motherBoard = motherBoard;
        }

        public void SetKeyboard(Keyboard keyboard)
        {
            this.keyboard = keyboard;
        }

        public void SetMouse(Mouse mouse)
        {
            this.mouse = mouse;
        }

        public void SetMonitor(Monitor monitor)
        {
            this.monitor = monitor;
        }

        public virtual string Dashboard()
        {
            return string.Empty;
        }
    }

}
