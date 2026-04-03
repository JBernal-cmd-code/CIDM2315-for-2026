namespace Homework9;
class Program
{
    static void Main(string[] args)
    {
        Student firstStu = new Student(111, "Alice");
        Student secondStu = new Student(222, "Bob");
        Student thirdStu = new Student(333, "Cathy");
        Student fourthStu = new Student(444, "David");

        Dictionary<string, double>gradebook = new Dictionary<string, double>();
        gradebook.Add("Alice",  4.0);
        gradebook.Add("Bob", 3.6);
        gradebook.Add("Cathy", 2.5);
        gradebook.Add("David", 1.8);

        if(!gradebook.ContainsKey("Tom"))
        {
            gradebook.Add("Tom", 3.3);
        }

        double addGrades = 0;
        foreach (var grade in gradebook.Values)
        {
            addGrades += grade;
        }
        double gpaAvg = addGrades / gradebook.Count;
        Console.WriteLine("The average GPA is: " + gpaAvg);

        foreach (Student stu in Student.studentList)
        {
            if(gradebook.ContainsKey(stu.GetName()) && gradebook[stu.GetName()] > gpaAvg)
            {
                stu.PrintInfo();
            }
        }
    }
}
    class Student
    {
        private int studentID;
        private string studentName;
        public void PrintInfo()
        {
            Console.WriteLine("Student ID: " + studentID + ", Student Name: " + studentName);
        }
        public static List<Student> studentList = new List<Student>();
        public Student(int id, string name)
        {
            studentID = id;
            studentName = name;
            studentList.Add(this);
        }
        public string GetName()
        {
            return studentName;
        }
    }
