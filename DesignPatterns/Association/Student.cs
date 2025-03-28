namespace DesignPatterns.Association
{
    public class Student
    {
        public string Name { get; }
        private string _homeWork;
        public int HomeWorkScore { get; private set; } = 50;

        public Student(string name, string homeWork = "Write your name on board")
        {
            Name = name;
            _homeWork = homeWork;
        }

        public void AssignTeacher(Teacher teacher)  // i sent obj from teacher not specfic type from teacher
        {
            _homeWork = teacher.AssignQuestion();
        }
        public void DoHomeWork()
        {
            HomeWorkScore = new Random().Next(0, 101);
        }
    }
}