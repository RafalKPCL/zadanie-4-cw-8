using System;

enum Gender
{
    Male,
    Female
}

struct Student
{
    public string LastName;
    public int StudentId;
    public float Grade;
    public Gender Gender;
}

class Program
{
    static void Main(string[] args)
    {
        Student[] students = new Student[5];

        for (int i = 0; i < students.Length; i++)
        {
            FillStudentInfo(ref students[i]);
            DisplayStudentInfo(students[i]);
        }

        float averageGrade = CalculateAverageGrade(students);
        Console.WriteLine("Average grade: " + averageGrade);
    }

    static void FillStudentInfo(ref Student student)
    {
        Console.Write("Last Name: ");
        student.LastName = Console.ReadLine();

        Console.Write("Student ID: ");
        student.StudentId = int.Parse(Console.ReadLine());

        Console.Write("Grade: ");
        float grade = float.Parse(Console.ReadLine());
        student.Grade = Math.Max(2.0f, Math.Min(5.0f, grade));

        Console.Write("Gender (Male/Female): ");
        string genderInput = Console.ReadLine();
        student.Gender = (genderInput.ToLower() == "male") ? Gender.Male : Gender.Female;
    }

    static void DisplayStudentInfo(Student student)
    {
        Console.WriteLine("Last Name: " + student.LastName +
                          ", Student ID: " + student.StudentId +
                          ", Grade: " + student.Grade +
                          ", Gender: " + student.Gender);
    }

    static float CalculateAverageGrade(Student[] students)
    {
        float sum = 0;

        foreach (var student in students)
        {
            sum += student.Grade;
        }

        return sum / students.Length;
    }
}
