using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SOLID_Case_Answer.Case_Answer_2_OCP
{
    #region Bad Code
    class PaymentProcessor
    {
        public void ProcessPayment(IProcess process)
        {
            process.ProcessPayment();
        }
    }
    public interface IProcess
    {
        void ProcessPayment();
    }
    class CreditCard : IProcess
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing payment via Credit Card");
        }
    }
    class PayPal : IProcess
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing payment via PayPal");
        }
    }
    #endregion
}
