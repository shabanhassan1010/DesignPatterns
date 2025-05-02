using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SOLID_Case_Answer.Case_Answer_3_LSP
{
    #region Bad Code
    public class Document
    {
        public Document(IPrint print)
        {
            print.Print();
        }
    }
        public interface IPrint
        {
             void Print();
        }
    public class ReadOnlyDocument
    {

    }
    public class EditOnlyDocument : IPrint , Document
    {
        public void Print()
        {
            Console.WriteLine("Read Only Document Print");
        }
    }
    public class DeleteOnlyDocument : IPrint , Document
    {
        public void Print()
        {
            Console.WriteLine("Read Only Document Print");
        }
    }
    #endregion
}
