// See https://aka.ms/new-console-template for more information
// Create teachers
using DesignPatterns.Association;
using DesignPatterns.FactoryMethod_DP.Buttons;
using DesignPatterns.FactoryMethod_DP.ContentValidtorExample.AppViewer;
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


MobileDialog mobileDialog = new MobileDialog();
MobileButton mobileButton = new MobileButton();
Console.WriteLine(mobileDialog.CreatedButton().Show());


SystemDailog systemDailog = new SystemDailog();
SystemButton systemButton = new SystemButton();
Console.WriteLine(systemDailog.CreatedButton().Show());
#endregion

