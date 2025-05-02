using System;

namespace SOLID.SOLID_Implement_2._2_5_DIP
{
    #region Bad Code
    public class Manager
    {
        //private readonly ITask task;
        //public Manager(ITask task)
        //{
        //    this.task = task;
        //}
        public void AssignTask(ITask task)
        {
            task.DoTask();
        }
    }
    public interface ITask
    {
        void DoTask();
    }
    public class Worker : ITask
    {
        public void DoTask()
        {
            Console.WriteLine("Task has been assigned");
        }
    }
    public class Enginner : ITask
    {
        public void DoTask()
        {
            Console.WriteLine("Task has been assigned");
        }
    }
    #endregion
}
