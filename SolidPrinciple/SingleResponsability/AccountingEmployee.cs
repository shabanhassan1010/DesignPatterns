using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple.SingleResponsability
{
    public class AccountingEmployee : Employee
    {
        public void CalculateSalary()
        {
            Console.WriteLine("The Role For This Employee Just CalculateSalary For Employee");
        }
    }
}
