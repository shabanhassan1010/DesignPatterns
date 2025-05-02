using SOLID.SOLID_Case_Answer.Case_Answer_1_SRP;
using SOLID.SOLID_Case_Answer.Case_Answer_2_OCP;
using SOLID.SOLID_Case_Answer.Case_Answer_3_LSP;
using SOLID.SOLID_Case_Answer.Case_Answer_4_ISP;
using SOLID.SOLID_Implement_2._2_1_SRP;
using SOLID.SOLID_Implement_2._2_4_ISP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Employee Case
            Employee emp = new Employee {Id = 1,Name = "Shaban" };

            AccountingEmployee accountingEmployee = new AccountingEmployee();
            accountingEmployee.CalculateSalary(emp);

            EmployeeRepository employeeRepository = new EmployeeRepository();
            employeeRepository.SaveEmployee(emp);
            #endregion

            #region Book Case
            Book book = new Book{ Title = "Clean Code", Author = "Robert C. Martin" };
            PrintBook printer = new PrintBook();
            printer.Print(book);

            SaveBook repository = new SaveBook();
            repository.Save(book);
            #endregion

            #region Order Case
            Order order = new Order{ Id = 1, Name = "Shaban", salary = 25000 };

            PrintOrder printOrder = new PrintOrder();
            printOrder.PrintInvoice(order);

            CalclateSalary salaryCalculator = new CalclateSalary();
            salaryCalculator.CalculateTotalSalary(order);
            #endregion

            #region Drawing Case
            IShape circle = new Circle1();
            IShape square = new Square();

            Drawing drawing = new Drawing();
            Console.WriteLine(drawing.DrawShape(circle));
            Console.WriteLine(drawing.DrawShape(square));
            #endregion

            #region PaymentProcessor Case
            IProcess creditCardPayment = new CreditCard();
            IProcess payPalPayment = new PayPal();

            PaymentProcessor paymentProcessor = new PaymentProcessor();

            paymentProcessor.ProcessPayment(creditCardPayment);  
            paymentProcessor.ProcessPayment(payPalPayment);
            #endregion

            #region Shape Case
            Shape rect = new Rectangle(4, 5);
            Shape circ = new Circle(3);

            Console.WriteLine($"Rectangle Area: {rect.Area}");
            Console.WriteLine($"Circle Area: {circ.Area}");
            #endregion

            #region Document Case
            //Document ReadOnly = new ReadOnlyDocument();
            //Document WriteOnly = new WriteOnlyDocument();
            //ReadOnly.Print();
            //WriteOnly.Print();
            #endregion

            #region Activity Case
            IWorkable workable = new Employee1();
            workable.Work();
            workable = new Engineer();
            workable.Work();
            workable = new Machine();
            workable.Work();
            #endregion

            #region IMultiFunctionDevice Case

            IPrinter oldPrinter = new OldPrinter();
            oldPrinter.Print();

            IMultiFunctionDevice mfd = new ModernPrinter();
            mfd.Print();
            mfd.Scan();
            mfd.Fax();

            #endregion

            IPrint print = new ReadOnlyDocument();
            Document document = new Document(print);

        }
    }
}
