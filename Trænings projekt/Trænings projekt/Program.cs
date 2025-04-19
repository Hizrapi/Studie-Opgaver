namespace Trænings_projekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.SetName("Alice");
            s1.SetGrade(85);

            Console.WriteLine($"Student: {s1.GetName()}, Grade: {s1.GetGrade()}");
        }
    }
    class Student
    {
        private string name;
        private int grade;

        public void SetName(string newName)
        {
            name = newName;            
        }
        
        public string GetName()
        { return name; }

        public void SetGrade(int newGrade)
        {
            if (newGrade >= 0 && newGrade <= 100)
            {
                grade = newGrade;
            }
        }

        public int GetGrade() { return grade; }

    }
}
