using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SOLID_Case_Answer.Case_Answer_4_ISP
{
    #region Bad Code
    public interface IMultiFunctionDevice : IPrinter , IFaxPrinter
    {
    }
    public interface IPrinter
    {
        void Print();
        void Scan();
    }
    public interface IFaxPrinter
    {
        void Fax();
    }
    public class OldPrinter :  IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Printing");
        }

        public void Scan()
        {
            Console.WriteLine("Scan OldPrinter");
        }
    }

    public class ModernPrinter : IMultiFunctionDevice
    {
        public void Print()
        {
            Console.WriteLine("Printing ModernPrinter");
        }

        public void Scan()
        {
            Console.WriteLine("Scanning ModernPrinter");
        }

        public void Fax()
        {
            Console.WriteLine("Fax ModernPrinter");
        }
    }

    #endregion

}
