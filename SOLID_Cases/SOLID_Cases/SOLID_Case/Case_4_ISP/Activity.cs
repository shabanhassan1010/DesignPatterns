using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SOLID_Implement_2._2_4_ISP
{
    #region Bad Code
    public interface IWorkable
    {
        void Work();
    }
    public interface IBreakable
    {
        void TakeBreak();
    }
    public interface ITimeTrackable
    {
        void ClockIn();
        void ClockOut();
    }
    public interface IMultitasking : ITimeTrackable, IWorkable, IBreakable
    {
    }
    public class Employee1 : ITimeTrackable
    {
        public void ClockIn()
        {
            Console.WriteLine("Employee clocked in.");
        }

        public void ClockOut()
        {
            Console.WriteLine("Employee clocked out.");
        }
    }
    public class Engineer : IMultitasking
    {
        public void ClockIn()
        {
            throw new NotImplementedException();
        }

        public void ClockOut()
        {
            throw new NotImplementedException();
        }

        public void TakeBreak()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    public class Machine : IWorkable, IBreakable
    {
        public void TakeBreak()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            Console.WriteLine("Machine is operating.");
        }
    }
    #endregion
}
