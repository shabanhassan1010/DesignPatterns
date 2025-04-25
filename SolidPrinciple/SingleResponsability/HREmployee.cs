using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple.SingleResponsability
{
    public class HREmployee : Employee
    {
        public void ConductInterview(string candidateName, string position)
        {
            Console.WriteLine($"Interview scheduled: {candidateName} for {position}");
        }
    }
}
