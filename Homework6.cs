namespace Homework6;

class Program
{
    static void Main(string[] args)
    {
        //Answer Q1 and Q2
        Professor p1 = new Professor();
        p1.profName = "Alice";
        p1.classTeach = "Java";
        p1.SetSalary(9000);
        p1.PrintProf();

        Professor p2 = new Professor();
        p2.profName = "Bob";
        p2.classTeach = "Math";
        p2.SetSalary(8000);
        p2.PrintProf();

        Student s1 = new Student();
        s1.studentName = "Lisa";
        s1.classEnroll = "Java";
        s1.SetGrade(90);
        s1.PrintStudent();

        Student s2 = new Student();
        s2.studentName = "Tom";
        s2.classEnroll = "Math";
        s2.SetGrade(80);
        s2.PrintStudent();

        double salDif = p1.GetSalary() - p2.GetSalary();
        double gradeDif = s1.GetGrade() + s2.GetGrade();
        Console.WriteLine("The salary difference between " + p1.profName + " and " + p2.profName + " is: " + salDif);
        Console.WriteLine("The total grade of " + s1.studentName + " and " + s2.studentName + " is: " + gradeDif);
    }
}

//Code for Professor class:
class Professor
{
    public string profName;
    public string classTeach;
    private double salary;
    public void SetSalary(double salary_amount)
    {
        salary = salary_amount;
    }
    public double GetSalary()
    {
        return salary;
    }
    public void PrintProf()
    {
        Console.WriteLine("Professor " + profName + " teaches " + classTeach + ", and the salary is: " + salary);
    }
}

//Code for Student class:
class Student
{
    public string studentName;
    public string classEnroll;
    private double studentGrade;
    public void SetGrade(double newGrade)
    {
        studentGrade = newGrade;
    }
    public double GetGrade()
    {
        return studentGrade;
    }
    public void PrintStudent()
    {
        Console.WriteLine("Student " + studentName + " enrolls " + classEnroll + ", and the grade is: " + studentGrade);
    }

}