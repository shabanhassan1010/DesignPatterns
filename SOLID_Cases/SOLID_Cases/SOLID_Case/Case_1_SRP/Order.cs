using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SOLID_Case_Answer.Case_Answer_1_SRP
{
    #region Bad Code
    class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int salary { get; set; }
    }
    class PrintOrder
    {
        public void PrintInvoice(Order order) 
        {
            Console.WriteLine($"{order.Name} and {order.Id}");
        }
    }
    class CalclateSalary
    {
        public int taxes = 10;
        public void CalculateTotalSalary(Order order)
        {
            int totalSalary = order.salary * taxes;
            Console.WriteLine($"Total salary after tax for {order.Name} = {totalSalary}");
        }
    }
    #endregion
}
