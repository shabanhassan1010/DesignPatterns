using DesignPatterns.FactoryMethod_DP.Buttons;
using DesignPatterns.FactoryMethod_DP.CreatorExample.Creator;
using DesignPatterns.FactoryMethod_DP.Dialog;

#region  Association
//var scienceTeacher = new ScienceTeacher("Shaban");
//var mathTeacher = new MathTeacher("Ali");
//var student = new Student("Mona");

//Console.WriteLine($"Initial homework: {student.HomeWorkScore}");

//// Assign math teacher and do homework
//student.AssignTeacher(mathTeacher);
//student.DoHomeWork();
//Console.WriteLine($"Math homework score: {student.HomeWorkScore}");
//Console.WriteLine($"Evaluation result: {mathTeacher.EvaluateStudentHomeWork(student)}");

//// Assign science teacher and do homework again
//student.AssignTeacher(scienceTeacher);
//student.DoHomeWork();
//Console.WriteLine($"Science homework score: {student.HomeWorkScore}");
//Console.WriteLine($"Evaluation result: {scienceTeacher.EvaluateStudentHomeWork(student)}");
#endregion


#region FactoryMethod Desing Pattern

//SystemDailog system = new SystemDailog();
//Console.WriteLine(system.RenderDialog());

//var htmlViewer = new HTMLAppViewer();
//Console.WriteLine(htmlViewer.ViewContentOnScreen());

//var xmlViewer = new XMLAppViewer();
//Console.WriteLine(xmlViewer.ViewContentOnScreen());


//MobileDialog mobileDialog = new MobileDialog();
//MobileButton mobileButton = new MobileButton();
//Console.WriteLine(mobileDialog.RenderDialog());

//SystemDailog systemDailog = new SystemDailog();
//SystemButton systemButton = new SystemButton();
//Console.WriteLine(systemDailog.CreatedButton().Show());

ConcreteCreator1 concreteCreator1 = new ConcreteCreator1();
Console.WriteLine(concreteCreator1.SomeOperation());
Console.WriteLine(concreteCreator1.FactoryMethod().Operation());

#endregion


#region Bulider DP

//try
//{
//// Create CS Computer
//var csBuilder = new ComputerCSBuilder();
//var director = new Director(csBuilder);
//var csComputer = director.MakeComputer();

//Console.WriteLine("Computer CS Built:");
//Console.WriteLine($"CPU Speed: {csComputer.GetMotherBoard().GetCpu().GetSpeed()} GHz");
//Console.WriteLine($"RAM Size:  {csComputer.GetMotherBoard().GetRam().GetSpeed()} GB");
//Console.WriteLine($"Disk Type: {csComputer.GetMotherBoard().GetDisk().GetDiskType()}");
//Console.WriteLine($"Dashboard: {csComputer.Dashboard()}");

//// Create XL Computer
//var xlBuilder = new ComputerXLBuilder();
//director.ChangeBuilder(xlBuilder);
//var xlComputer = director.MakeComputer();

//Console.WriteLine("\nComputer XL Built:");
//Console.WriteLine($"Network Category:    {xlComputer.GetMotherBoard().GetNetworkCard().GetCategory()}");
//Console.WriteLine($"Cooling System Temp: {((ComputerXL)xlComputer).GetCs().IsUtfSupport()}");
//Console.WriteLine($"UPS Duration: {((ComputerXL)xlComputer).GetUps().IsUtfSupport()} minutes");
//Console.WriteLine($"Backup Power Status: {((ComputerXL)xlComputer).BackupPower()}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Error building computer: {ex.Message}");
//}

#endregion