using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SOLID_Implement_2._2_1_SRP
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
    public class AccountingEmployee
    { 
        public void CalculateSalary(Employee employee)
        {
            Console.WriteLine($"Calculating salary for {employee.Name}");
        }
    }
    public class EmployeeRepository 
    {
        public void SaveEmployee(Employee employee)
        {
            Console.WriteLine($"Saving {employee.Name} to the database");
        }
    }
}
